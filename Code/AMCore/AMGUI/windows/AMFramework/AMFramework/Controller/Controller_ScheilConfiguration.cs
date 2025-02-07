﻿using AMFramework_Lib.Controller;
using AMFramework_Lib.Core;
using AMFramework_Lib.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AMFramework.Controller
{
    public class Controller_ScheilConfiguration : ControllerAbstract
    {
        #region Socket
        private IAMCore_Comm _AMCore_Socket;
        private Controller_Cases _caseController;
        public Controller_ScheilConfiguration(ref IAMCore_Comm socket, Controller_Cases caseController)
        {
            _AMCore_Socket = socket;
            _caseController = caseController;
        }
        #endregion

        #region Data
        Model_ScheilConfiguration _model = new();
        public Model_ScheilConfiguration Model
        {
            get { return _model; }
            set
            {
                _model = value;
                OnPropertyChanged(nameof(Model));
            }
        }

        public void save(Model_ScheilConfiguration model)
        {
            string outComm = _AMCore_Socket.run_lua_command("spc_scheil_configuration_save", model.Get_csv());
            if (!outComm.All(char.IsDigit))
            {
                MainWindow.notify.ShowBalloonTip(5000, "Error: Case was not saved", outComm, System.Windows.Forms.ToolTipIcon.Error);
            }
        }
        public Model_ScheilConfiguration get_scheil_configuration_case(int IDCase)
        {
            Model_ScheilConfiguration model = new();
            string Query = "database_table_custom_query SELECT ScheilConfiguration.*, Phase.Name FROM ScheilConfiguration INNER JOIN Phase ON Phase.ID=ScheilConfiguration.DependentPhase WHERE IDCase = " + IDCase;
            string outCommand = _AMCore_Socket.run_lua_command(Query, "");
            List<string> rowItems = outCommand.Split("\n").ToList();

            if (rowItems.Count == 0) return model;
            List<string> columnItems = rowItems[0].Split(",").ToList();
            if (columnItems.Count < 7)
            {
                //model
                return model;
            }
            model = fillModel(columnItems);

            return model;
        }

        private static Model_ScheilConfiguration fillModel(List<string> DataRaw)
        {
            if (DataRaw.Count < 7) throw new Exception("Error: Element RawData is wrong");

            Model_ScheilConfiguration modely = new()
            {
                ID = Convert.ToInt32(DataRaw[0]),
                IDCase = Convert.ToInt32(DataRaw[1]),
                StartTemperature = Convert.ToDouble(DataRaw[2]),
                EndTemperature = Convert.ToDouble(DataRaw[3]),
                StepSize = Convert.ToDouble(DataRaw[4]),
                DependentPhase = Convert.ToInt32(DataRaw[5]),
                MinLiquidFraction = Convert.ToDouble(DataRaw[6]),
                DependentPhaseName = DataRaw[7]
            };
            return modely;
        }
        #endregion

        #region Getters
        public Controller.Controller_Cases CaseController
        {
            get { return _caseController; }
        }
        #endregion
    }
}
