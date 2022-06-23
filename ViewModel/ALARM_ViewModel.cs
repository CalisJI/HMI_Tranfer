using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMITranfer.ViewModel
{
    public class ALARM_ViewModel : BaseViewModel
    {
        private static ALARM_ViewModel _ViewModel;

        public static ALARM_ViewModel INS_ALARM_ViewModel
        {
            get
            {
                if (_ViewModel != null)
                {
                    return _ViewModel;
                }
                else
                {
                    _ViewModel = new ALARM_ViewModel();
                    return _ViewModel;
                }
            }
            set => _ViewModel = value;
        }
        public ALARM_ViewModel()
        {

        }
    }
}
