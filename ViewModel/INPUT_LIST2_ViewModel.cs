using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMITranfer.ViewModel
{
    public class INPUT_LIST2_ViewModel : BaseViewModel
    {
        private static INPUT_LIST2_ViewModel _ViewModel;

        public static INPUT_LIST2_ViewModel INS_INPUT_LIST2_ViewModel
        {
            get
            {
                if (_ViewModel != null)
                {
                    return _ViewModel;
                }
                else
                {
                    _ViewModel = new INPUT_LIST2_ViewModel();
                    return _ViewModel;
                }
            }
            set => _ViewModel = value;
        }
        public INPUT_LIST2_ViewModel()
        {

        }
    }
}
