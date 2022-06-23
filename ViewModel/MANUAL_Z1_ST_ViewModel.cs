using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HMITranfer.ViewModel
{
    public class MANUAL_Z1_ST_ViewModel : BaseViewModel
    {
        #region Singleton
        private static MANUAL_Z1_ST_ViewModel _ViewModel;

        public static MANUAL_Z1_ST_ViewModel INS_MANUAL_Z1_ST_ViewModel
        {
            get
            {
                if (_ViewModel != null)
                {
                    return _ViewModel;
                }
                else
                {
                    _ViewModel = new MANUAL_Z1_ST_ViewModel();
                    return _ViewModel;
                }
            }
            set => _ViewModel = value;
        }
        #endregion


        #region command
        public ICommand BUFFER_CYL_Z1_1_DOWN_COMMAND { get; set; }
        public ICommand BUFFER_CYL_Z1_1_UP_COMMAND { get; set; }


        public ICommand BUFFER_CYL_Z1_2_DOWN_COMMAND { get; set; }
        public ICommand BUFFER_CYL_Z1_2_UP_COMMAND { get; set; }

        public ICommand SEPARATED_CYL_Z1_ST_DOWN_COMMAND { get; set; }
        public ICommand SEPARATED_CYL_Z1_ST_UP_COMMAND { get; set; }

        public ICommand LIFT_CYL_Z1_ST_DOWN_COMMAND { get; set; }
        public ICommand LIFT_CYL_Z2_ST_UP_COMMAND { get; set; }

        public ICommand HOLD_CYL_Z1_ST_DOWN_COMMAND { get; set; }
        public ICommand HOLD_CYL_Z1_ST_UP_COMMAND { get; set; }

        public ICommand BEHIND_CYL_Z1_ST_DOWN_COMMAND { get; set; }
        public ICommand BEHIND_CYL_Z1_ST_UP_COMMAND { get; set; }


        #endregion
        public MANUAL_Z1_ST_ViewModel()
        {
            BUFFER_CYL_Z1_1_DOWN_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M3.5", true);
                }
            });
            BUFFER_CYL_Z1_1_UP_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M3.5", false);
                }
            });
            BUFFER_CYL_Z1_2_DOWN_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M3.6", true);
                }
            });
            BUFFER_CYL_Z1_2_UP_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M3.6", false);
                }
            });
            SEPARATED_CYL_Z1_ST_DOWN_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M3.7", true);
                }
            });
            SEPARATED_CYL_Z1_ST_UP_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M3.7", false);
                }
            });
            LIFT_CYL_Z1_ST_DOWN_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M4.0", false);
                }
            });
            LIFT_CYL_Z2_ST_UP_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M4.0", true);
                }
            });
            HOLD_CYL_Z1_ST_DOWN_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M4.1", true);
                }
            });
            HOLD_CYL_Z1_ST_UP_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M4.1", false);
                }
            });
            BEHIND_CYL_Z1_ST_DOWN_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M4.2", true);
                }
            });
            BEHIND_CYL_Z1_ST_UP_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M4.2", false);
                }
            });
        }
    }
}
