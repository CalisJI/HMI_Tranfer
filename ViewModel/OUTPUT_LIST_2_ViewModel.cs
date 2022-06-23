using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMITranfer.ViewModel
{
    public class OUTPUT_LIST_2_ViewModel : BaseViewModel
    {
        private static OUTPUT_LIST_2_ViewModel _ViewModel;

        public static OUTPUT_LIST_2_ViewModel INS_OUTPUT_LIST_2_ViewModel
        {
            get
            {
                if (_ViewModel != null)
                {
                    return _ViewModel;
                }
                else
                {
                    _ViewModel = new OUTPUT_LIST_2_ViewModel();
                    return _ViewModel;
                }
            }
            set => _ViewModel = value;
        }
        public OUTPUT_LIST_2_ViewModel()
        {

        }
    }
}
