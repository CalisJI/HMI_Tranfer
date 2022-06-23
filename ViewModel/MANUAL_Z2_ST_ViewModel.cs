using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HMITranfer.ViewModel
{
    public class MANUAL_Z2_ST_ViewModel : BaseViewModel
    {
        #region SingleTon
        private static MANUAL_Z2_ST_ViewModel _ViewModel;

        public static MANUAL_Z2_ST_ViewModel INS_MANUAL_Z2_ST_ViewModel
        {
            get
            {
                if (_ViewModel != null)
                {
                    return _ViewModel;
                }
                else
                {
                    _ViewModel = new MANUAL_Z2_ST_ViewModel();
                    return _ViewModel;
                }
            }
            set => _ViewModel = value;
        }
        #endregion

        #region Command
        public ICommand SEPARATED_CYL_Z2_ST_DOWN_COMMAND { get; set; }
        public ICommand SEPARATED_CYL_Z2_ST_UP_COMMAND { get; set; }


        public ICommand LIFT_CYL_Z2_ST_DOWN_COMMAND { get; set; }
        public ICommand LIFT_CYL_Z2_ST_UP_COMMAND { get; set; }


        public ICommand HOLD_CYL_Z2_ST_DOWN_COMMAND { get; set; }
        public ICommand HOLD_CYL_Z2_ST_UP_COMMAND { get; set; }

        public ICommand BEHIND_CYL_Z2_ST_DOWN_COMMAND { get; set; }
        public ICommand BEHIND_CYL_Z2_ST_UP_COMMAND { get; set; }

        #endregion
        public MANUAL_Z2_ST_ViewModel()
        {
            SEPARATED_CYL_Z2_ST_DOWN_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M4.3", true);
                }
            });
            SEPARATED_CYL_Z2_ST_UP_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M4.3", false);
                }
            });
            LIFT_CYL_Z2_ST_DOWN_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M4.4", false);
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
                    MainScreen_ViewModel.S71200.Write("M4.4", true);
                }
            });
            HOLD_CYL_Z2_ST_DOWN_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M4.5", true);
                }
            });
            HOLD_CYL_Z2_ST_UP_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M4.5", false);
                }
            });
            BEHIND_CYL_Z2_ST_DOWN_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M4.6", true);
                }
            });
            BEHIND_CYL_Z2_ST_UP_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M4.6", false);
                }
            });
        }
    }
}
