using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HMITranfer.ViewModel
{
    public class MANUAL_Y_ST_ViewModel : BaseViewModel
    {
        #region singleton
        private static MANUAL_Y_ST_ViewModel _ViewModel;

        public static MANUAL_Y_ST_ViewModel INS_MANUAL_Y_ST_ViewModel
        {
            get
            {
                if (_ViewModel != null)
                {
                    return _ViewModel;
                }
                else
                {
                    _ViewModel = new MANUAL_Y_ST_ViewModel();
                    return _ViewModel;
                }
            }
            set => _ViewModel = value;
        }
        #endregion

        #region command
        public ICommand BUFFER_CYL_Y_1_UP_COMMAND { get; set; }
        public ICommand BUFFER_CYL_Y_1_DOWN_COMMAND { get; set; }


        public ICommand BUFFER_CYL_Y2_UP_COMMAND { get; set; }
        public ICommand BUFFER_CYL_Y2_DOWN_COMMAND { get; set; }

        public ICommand SEPARATED_CYL_Y_ST_UP_COMMAND { get; set; }
        public ICommand SEPARATED_CYL_Y_ST_DOWN_COMMAND { get; set; }

        public ICommand LIFT_CYL_Y_ST_UP_COMMAND { get; set; }
        public ICommand LIFT_CYL_Y_ST_DOWN_COMMAND { get; set; }

        public ICommand BEHIND_CYL_Y_ST_UP_COMMAND { get; set; }
        public ICommand BEHIND_CYL_Y_ST_DOWN_COMMAND { get; set; }
        #endregion
        public MANUAL_Y_ST_ViewModel()
        {
            BUFFER_CYL_Y_1_UP_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M3.0", false);
                }
            });
            BUFFER_CYL_Y_1_DOWN_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M3.0", true);
                }
            });
            BUFFER_CYL_Y2_UP_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M3.1", false);
                }
            });
            BUFFER_CYL_Y2_DOWN_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M3.1", true);
                }
            });
            SEPARATED_CYL_Y_ST_UP_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M3.2", false);
                }
            });
            SEPARATED_CYL_Y_ST_DOWN_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M3.2", true);
                }
            });
            LIFT_CYL_Y_ST_UP_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M3.3", true);
                }
            });
            LIFT_CYL_Y_ST_DOWN_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M3.3", false);
                }
            });
            BEHIND_CYL_Y_ST_UP_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M3.4", false);
                }
            });
            BEHIND_CYL_Y_ST_DOWN_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M3.4", true);
                }
            });

        }
    }
}
