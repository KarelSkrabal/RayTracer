using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System.Windows;
using RayTracerWPF.Model;


namespace RayTracerWPF.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService)
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            //commands
            Page2Command = new RelayCommand(() => GoToPage2());

            _dataService = dataService;
            _dataService.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        return;
                    }
                    CanvasWidth = item.CanvasWidth;
                });
            ExampleValue = 10;
        }

        int _exampleValue;
        public int ExampleValue
        {
            get
            {
                return _exampleValue;
            }
            set
            {
                if (_exampleValue == value)
                    return;
                _exampleValue = value;
                Set(ref _exampleValue, value);
                RaisePropertyChanged("ExampleValue");
            }
        }

        private double _canvasWidth;
        public double CanvasWidth
        {
            get => _canvasWidth;
            set => Set(ref _canvasWidth, value);//does it raisePropertyChanged??????? 
        }

        public RelayCommand Page2Command
        {
            get;
            private set;
        }
        private object GoToPage2()
        {
            //var msg = new GoToPageMessage() { PageName = "Page2View" };
            //Messenger.Default.Send<GoToPageMessage>(msg);

            System.Windows.MessageBox.Show("Navigate to Page 2!");
            return null;
        }
    }
}