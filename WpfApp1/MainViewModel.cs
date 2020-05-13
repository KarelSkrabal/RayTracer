using System.Windows.Input;
using System.Windows;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RayTracerTest.MVVMCodeBase;
using System;

namespace RayTracerTest
{
    public class MainViewModel 
    {
        public MainViewModel()
        {
            _spheresXX.Add(new RayTracerViewModel { RadiusXXXX = 50.0, CenterX = 200.0, CenterY = 300.0, CenterZ = 10, Color = "xxx" });
            _spheresXX.Add(new RayTracerViewModel { RadiusXXXX = 250.0, CenterX = 220.0, CenterY = 300.0, CenterZ = 20, Color = "aa" });
            _spheresXX.Add(new RayTracerViewModel { RadiusXXXX = 150.0, CenterX = 250.0, CenterY = 30.0, CenterZ = 30, Color = "yyy" });
        }

        public ICommand AddSphere { get { return new RelayCommand(AddSphereExecute, CanAddSphereExecute); } }

        private bool CanAddSphereExecute() => true;

        private void AddSphereExecute()
        {
            RayTracerViewModel newItem = new RayTracerViewModel
            {
                CenterX = SelectedSphere.CenterX,
                CenterY = SelectedSphere.CenterY,
                CenterZ = SelectedSphere.CenterZ,
                SphereObject = new SphereObject
                {
                    CenterX = SelectedSphere.CenterX,
                    CenterY = SelectedSphere.CenterY,
                    CenterZ = SelectedSphere.CenterZ,
                    Color = SelectedSphere.Color,
                    RadiusXX = SelectedSphere.RadiusXXXX
                }
            };
            SpheresXX.Add(newItem);
        }

        public ICommand NewSphere { get { return new RelayCommand(NewSphereExecute, CanNewSphereExecute); } }

        private bool CanNewSphereExecute() => true;

        private void NewSphereExecute()
        {
            _newSphere = new RayTracerViewModel();
            SpheresXX.Insert(0,_newSphere);
            SelectedSphere = _newSphere;


            //SelectedSphere = null;
            //SelectedSphere = SpheresXX.LastOrDefault();
            //_newSphere = new RayTracerViewModel();
            //_newSphere = SelectedSphere;
            //SelectedSphere.CenterX = 0;
            //SelectedSphere.CenterY = 0;
            //SelectedSphere.CenterZ = 0;
            //SelectedSphere.RadiusXXXX = 0;
            //SelectedSphere.Color = string.Empty;

            //SpheresXX.Add(_newSphere);
            }

        public ICommand DeleteSphere { get { return new RelayCommand(DeleteSphereExecute, CanDeleteSphereExecute); } }

        private bool CanDeleteSphereExecute() => true;

        private void DeleteSphereExecute() => SpheresXX.Remove(SelectedSphere);

        private ObservableCollection<RayTracerViewModel> _spheresXX = new ObservableCollection<RayTracerViewModel>();
        private ObservableCollection<RayTracerViewModel> _spheresXX1 = new ObservableCollection<RayTracerViewModel>();
        public ObservableCollection<RayTracerViewModel> SpheresXX
        {
            get => _spheresXX;
            set => _spheresXX = value;
        }
        public ObservableCollection<RayTracerViewModel> SpheresXX1
        {
            get => _spheresXX1;
            set => _spheresXX1 = value;
        }
        private SphereObject xxx = new SphereObject();
        public SphereObject Xxx
        {
            get; set;
        }

        private RayTracerViewModel _selectedSphere = new RayTracerViewModel();
        public RayTracerViewModel SelectedSphere
        {
            get => _selectedSphere;
            set
            {
                _selectedSphere = value;
                //_indexLastSelectedSphere = SpheresXX.IndexOf(_selectedSphere);
                Xxx = SelectedSphere.SphereObject;
            }
        }

        //private int _indexLastSelectedSphere = -1;
        private RayTracerViewModel _newSphere = null;
    }
}