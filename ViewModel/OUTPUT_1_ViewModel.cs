using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMITranfer.ViewModel
{
    public class OUTPUT_1_ViewModel : BaseViewModel
    {
        private static OUTPUT_1_ViewModel _ViewModel;

        public static OUTPUT_1_ViewModel INS_OUTPUT_1_ViewModel
        {
            get
            {
                if (_ViewModel != null)
                {
                    return _ViewModel;
                }
                else
                {
                    _ViewModel = new OUTPUT_1_ViewModel();
                    return _ViewModel;
                }
            }
            set => _ViewModel = value;
        }
        public OUTPUT_1_ViewModel()
        {

        }
    }
}
