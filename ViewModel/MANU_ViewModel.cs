using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace HMITranfer.ViewModel
{
    public class MANU_ViewModel : BaseViewModel
    {
        #region SingleTon
        private static MANU_ViewModel _ViewModel;

        public static MANU_ViewModel INS_MANU_ViewModel
        {
            get
            {
                if (_ViewModel != null)
                {
                    return _ViewModel;
                }
                else
                {
                    _ViewModel = new MANU_ViewModel();
                    return _ViewModel;
                }
            }
            set => _ViewModel = value;
        }
        #endregion

        #region Model

        #endregion

        #region Command Excute
        public ICommand BUFFER_CYL_X_UP_COMMAND { get; set; }
        public ICommand BUFFER_CYL_X_DOWN_COMMAND { get; set; }



        public ICommand SEPARATED_CYL_X_UP_cOMMAND { get; set; }
        public ICommand SEPARATED_CYL_X_DOWN_COMMAND { get; set; }

        public ICommand LIFTCYL_X_UP_COMMAND { get; set; }
        public ICommand LIFTCYL_X_DOWN_COMMMAND { get; set; }

        public ICommand BEHIND_CYL_X_UP_COMMAND { get; set; }
        public ICommand BEHIND_CYL_X_DOWN_COMMAND { get; set; }
        #endregion


        public MANU_ViewModel()
        {
            BUFFER_CYL_X_UP_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if(MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M2.4", false);
                }
            });
            BUFFER_CYL_X_DOWN_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M2.4", true);
                }
            });


            SEPARATED_CYL_X_UP_cOMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M2.5", false);
                }
            });
            SEPARATED_CYL_X_DOWN_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M2.5", true);
                }
            });


            LIFTCYL_X_UP_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M2.6", true);
                }
                
            });
            LIFTCYL_X_DOWN_COMMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M2.6", false);
                }
            });


            BEHIND_CYL_X_UP_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M2.7", false);
                }
            });
            BEHIND_CYL_X_DOWN_COMMAND = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainScreen_ViewModel.S71200 == null)
                {
                    return;
                }
                if (MainScreen_ViewModel.S71200.IsConnected)
                {
                    MainScreen_ViewModel.S71200.Write("M2.7", true);
                }
            });
           
        }
    }
    public class BoolToColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool a = (bool)value;
            return a ? Colors.Green : (object)Colors.Blue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
    public class BoolToColorInvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool a = (bool)value;
            return a ? Colors.Blue : (object)Colors.Green;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
