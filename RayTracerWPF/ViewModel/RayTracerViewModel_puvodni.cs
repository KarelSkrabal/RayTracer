using RayTracerWPF.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace RayTracerWPF.ViewModel
{
    public class RayTracerViewModel_puvodni /*: INotifyPropertyChanged*/
    {
        public ObservableCollection<RayTracerModel> RayTracerData
        {
            get;
            set;
        }

        private ICommand _saveSceneSettingsCommand ;
        public ICommand SaveSceneSettingsCommand
        {
            get
            {
                if (_saveSceneSettingsCommand == null)
                    _saveSceneSettingsCommand = new Command(ExecuteSaveSceneSettings);
                return _saveSceneSettingsCommand;
            }
            set { _saveSceneSettingsCommand = value; }
        }

        //private RayTracerModel _rayTracer;
        //public RayTracerModel RayTracer
        //{
        //    get => _rayTracer;
        //    set {
        //        _rayTracer = value;
        //        OnPropertyChanged("RayTracer");
        //    }
        //}
        public RayTracerViewModel_puvodni()
        {
            LoadRayTracer();
            //SaveSceneSettingsCommand = new CustomCommand(OnSaveSceneSettingsCommand, CanSaveSceneSettingsCommand);
            //SaveSceneSettingsCommand.RaiseCanExecuteChanged();
            SaveSceneSettingsCommand = new Command(ExecuteSaveSceneSettings);
        }

        public void LoadRayTracer()
        {
            ObservableCollection<RayTracerModel> rayTracerModelData = new ObservableCollection<RayTracerModel>();
            var rayTracer = new RayTracerModel()
            {
                CanvasWidth = "10",
                CanvasHeight = "20",
                LightPositionX = "20",
                LightPositionY = "30",
                LightPositionZ = "40",
                LightDirectionX = "50",
                LightDirectionY = "60",
                LightDirectionZ = "70",
                CameraPositionX = "80",
                CameraPositionY = "90",
                CameraPositionZ = "100",
                
            };
            rayTracerModelData.Add(rayTracer);
            this.RayTracerData = rayTracerModelData;
        }



        private void ExecuteSaveSceneSettings()
        {
            //do something
            var i = 10;
            i++;
        }
        //private void OnSaveSceneSettingsCommand()
        //{
        //    var t = 10;
        //    t++;
        //    ;
        //}

        //private bool CanSaveSceneSettingsCommand()
        //{
        //    return true;
        //}

        //public event PropertyChangedEventHandler PropertyChanged;

        //public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
