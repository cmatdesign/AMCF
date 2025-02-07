﻿using AMFramework_Lib.AMSystem.Attributes;

namespace AMFramework_Lib.Model
{
    public class Model_HeatTreatment : ModelAbstract
    {
        private int _id = -1;
        [Order]
        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(ID));
            }
        }

        private int _idCase = -1;
        [Order]
        public int IDCase
        {
            get { return _idCase; }
            set
            {
                _idCase = value;
                OnPropertyChanged(nameof(IDCase));
            }
        }

        private string _name = "";
        [Order]
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private int _maxTemperatureStep = 10;
        [Order]
        public int MaxTemperatureStep
        {
            get { return _maxTemperatureStep; }
            set
            {
                _maxTemperatureStep = value;
                OnPropertyChanged(nameof(MaxTemperatureStep));
            }
        }

        private int _idPrecipitationDomain = -1;
        [Order]
        public int IDPrecipitationDomain
        {
            get { return _idPrecipitationDomain; }
            set
            {
                _idPrecipitationDomain = value;
                OnPropertyChanged(nameof(IDPrecipitationDomain));
            }
        }

        private double _startTemperature = -1;
        [Order]
        public double StartTemperature
        {
            get { return _startTemperature; }
            set
            {
                _startTemperature = value;
                OnPropertyChanged(nameof(StartTemperature));
            }
        }

        #region Other
        private string _templatedStartTemperature = "";
        public string TemplatedStartTemperature
        {
            get { return _templatedStartTemperature; }
            set
            {
                _templatedStartTemperature = value;
                OnPropertyChanged(nameof(TemplatedStartTemperature));
            }
        }
        #endregion


        #region Interfaces
        public override IOrderedEnumerable<System.Reflection.PropertyInfo> Get_parameter_list()
        {
            return ModelAbstract.Get_parameters<Model_HeatTreatment>();
        }

        public override string Get_Table_Name()
        {
            return "HeatTreatment";
        }

        public override string Get_Scripting_ClassName()
        {
            return "HeatTreatment";
        }
        #endregion

        List<ModelController<Model_HeatTreatmentProfile>> _HeatTreatmentProfile = new();
        public List<ModelController<Model_HeatTreatmentProfile>> HeatTreatmentProfile
        {
            get { return _HeatTreatmentProfile; }
            set
            {
                _HeatTreatmentProfile = value;
                OnPropertyChanged(nameof(HeatTreatmentProfile));
            }
        }

        List<ModelController<Model_HeatTreatmentSegment>> _HeatTreatmentSegment = new();
        public List<ModelController<Model_HeatTreatmentSegment>> HeatTreatmentSegment
        {
            get { return _HeatTreatmentSegment; }
            set
            {
                _HeatTreatmentSegment = value;
                OnPropertyChanged(nameof(HeatTreatmentSegment));
            }
        }

        List<ModelController<Model_PrecipitateSimulationData>> _precipitationData = new();
        public List<ModelController<Model_PrecipitateSimulationData>> PrecipitationData
        {
            get { return _precipitationData; }
            set
            {
                _precipitationData = value;
                OnPropertyChanged(nameof(PrecipitationData));
            }
        }

        ModelController<Model_PrecipitationDomain>? _precipitationDomain;
        public ModelController<Model_PrecipitationDomain>? PrecipitationDomain
        {
            get { return _precipitationDomain; }
            set
            {
                _precipitationDomain = value;
                OnPropertyChanged(nameof(PrecipitationDomain));
            }
        }


        List<Model.Model_HeatTreatmentProfile> _HeatTreatmentProfileOLD = new();
        public List<Model.Model_HeatTreatmentProfile> HeatTreatmentProfileOLD
        {
            get { return _HeatTreatmentProfileOLD; }
            set
            {
                _HeatTreatmentProfileOLD = value;
                OnPropertyChanged(nameof(HeatTreatmentProfileOLD));
            }
        }

        List<Model.Model_PrecipitateSimulationData> _precipitationDataOLD = new();
        public List<Model.Model_PrecipitateSimulationData> PrecipitationDataOLD
        {
            get { return _precipitationDataOLD; }
            set
            {
                _precipitationDataOLD = value;
                OnPropertyChanged(nameof(PrecipitationDataOLD));
            }
        }

    }
}
