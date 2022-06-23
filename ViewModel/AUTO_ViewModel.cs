using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HMITranfer.ViewModel
{
    public class AUTO_ViewModel : BaseViewModel
    {
        private static AUTO_ViewModel _ViewModel;

        public static AUTO_ViewModel INS_AUTO_ViewModel
        {
            get
            {
                if (_ViewModel != null)
                {
                    return _ViewModel;
                }
                else
                {
                    _ViewModel = new AUTO_ViewModel();
                    return _ViewModel;
                }
            }
            set => _ViewModel = value;
        }

        #region Model

        private string _blname1;

        public string BtnNameZ1
        {
            get => _blname1;
            set => SetProperty(ref _blname1, value, nameof(BtnNameZ1));
        }
        private string _blname2;

        public string BtnNameZ2
        {
            get => _blname2;
            set => SetProperty(ref _blname2, value, nameof(BtnNameZ2));
        }
        #endregion

        #region Icommand
        public ICommand UnBlock_Z1_ST_Command { get; set; }
        public ICommand UnBlock_Z2_ST_Command { get; set; }



        public ICommand RESET_TRAY_X { get; set; }
        public ICommand RESET_TRAY_Y { get; set; }
        public ICommand RESET_TRAY_Z1 { get; set; }
        public ICommand RESET_TRAY_Z2 { get; set; }


        #endregion
        public AUTO_ViewModel()
        {
            UnBlock_Z1_ST_Command = new RelayCommand<object>((p) => { return true; }, (P) =>
            {
                if (MainScreen_ViewModel.S71200.IsConnected)
                {

                    bool a = (bool)MainScreen_ViewModel.S71200.Read("M13.3");
                    if (a)
                    {
                        BtnNameZ1 = "UNBLOCK Z1 ST";
                        MainScreen_ViewModel.S71200.Write("M13.3", false);
                    }
                    else
                    {
                        BtnNameZ1 = "BLOCK Z1 ST";
                        MainScreen_ViewModel.S71200.Write("M13.3", true);
                    }
                }
            });
            UnBlock_Z2_ST_Command = new RelayCommand<object>((p) => { return true; }, (P) =>
            {
                if (MainScreen_ViewModel.S71200.IsConnected)
                {

                    bool a = (bool)MainScreen_ViewModel.S71200.Read("M13.4");
                    if (a)
                    {
                        BtnNameZ2 = "UNBLOCK Z2 ST";
                        MainScreen_ViewModel.S71200.Write("M13.4", false);
                    }
                    else
                    {
                        BtnNameZ2 = "BLOCK Z2 ST";
                        MainScreen_ViewModel.S71200.Write("M13.4", true);
                    }
                }
            });
            RESET_TRAY_X = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SetOnPulseX();
            });
            RESET_TRAY_Y = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SetOnPulseY();
            });
            RESET_TRAY_Z1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SetOnPulseZ1();

            });
            RESET_TRAY_Z2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SetOnPulseZ2();
            });


        }

        #region Method

        async void SetOnPulseX()
        {
            void act()
            {
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M70.3", true);
                    _ = Task.Delay(1);
                    MainScreen_ViewModel.S71200.Write("M70.3", false);
                }
            }
            Task a = new Task(act);
            a.Start();
            await a;
        }

        async void SetOnPulseY()
        {
            void act()
            {
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M70.4", true);
                    _ = Task.Delay(1);
                    MainScreen_ViewModel.S71200.Write("M70.4", false);
                }
            }
            Task a = new Task(act);
            a.Start();
            await a;
        }

        async void SetOnPulseZ1()
        {
            void act()
            {
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M70.5", true);
                    _ = Task.Delay(1);
                    MainScreen_ViewModel.S71200.Write("M70.5", false);
                }
            }
            Task a = new Task(act);
            a.Start();
            await a;
        }

        async void SetOnPulseZ2()
        {
            void act()
            {
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M70.6", true);
                    _ = Task.Delay(1);
                    MainScreen_ViewModel.S71200.Write("M70.6", false);
                }
            }
            Task a = new Task(act);
            a.Start();
            await a;
        }
        #endregion
    }
}
