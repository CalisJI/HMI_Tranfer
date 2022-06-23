using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMITranfer.ViewModel
{
    public class INPUT_LIST_1_ViewModel : BaseViewModel
    {
        private static INPUT_LIST_1_ViewModel _ViewModel;

        public static INPUT_LIST_1_ViewModel INS_INPUT_LIST_1_ViewModel
        {
            get
            {
                if (_ViewModel != null)
                {
                    return _ViewModel;
                }
                else
                {
                    _ViewModel = new INPUT_LIST_1_ViewModel();
                    return _ViewModel;
                }
            }
            set => _ViewModel = value;
        }

        public INPUT_LIST_1_ViewModel()
        {

        }
    }
}
