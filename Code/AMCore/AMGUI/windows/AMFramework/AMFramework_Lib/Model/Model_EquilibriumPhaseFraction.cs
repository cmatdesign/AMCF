﻿using AMFramework_Lib.AMSystem.Attributes;

namespace AMFramework_Lib.Model
{
    public class Model_EquilibriumPhaseFraction : ModelAbstract
    {
        private int _ID = -1;
        [Order]
        public int ID
        {
            get { return _ID; }
            set
            {
                _ID = value;
                OnPropertyChanged(nameof(ID));
            }
        }

        private int _IDCase = -1;
        [Order]
        public int IDCase
        {
            get { return _IDCase; }
            set
            {
                _IDCase = value;
                OnPropertyChanged(nameof(IDCase));
            }
        }

        private int _IDPhase = -1;
        [Order]
        public int IDPhase
        {
            get { return _IDPhase; }
            set
            {
                _IDPhase = value;
                OnPropertyChanged(nameof(IDPhase));
            }
        }

        private string _typeComposition = "";
        [Order]
        public string TypeComposition
        {
            get { return _typeComposition; }
            set
            {
                _typeComposition = value;
                OnPropertyChanged(nameof(TypeComposition));
            }
        }

        private double _Temperature = -1;
        [Order]
        public double Temperature
        {
            get { return _Temperature; }
            set
            {
                _Temperature = value;
                OnPropertyChanged(nameof(Temperature));
            }
        }

        private double _value = -1;
        [Order]
        public double Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        #region Other
        private string _phaseName = "";
        public string PhaseName
        {
            get { return _phaseName; }
            set
            {
                _phaseName = value;
                OnPropertyChanged(nameof(PhaseName));
            }
        }
        #endregion

        #region Interfaces
        public override IOrderedEnumerable<System.Reflection.PropertyInfo> Get_parameter_list()
        {
            return ModelAbstract.Get_parameters<Model_EquilibriumPhaseFraction>();
        }

        public override string Get_Table_Name()
        {
            return "EquilibriumPhaseFraction";
        }

        public override string Get_Scripting_ClassName()
        {
            return "EquilibriumPhaseFraction";
        }
        #endregion
    }
}
