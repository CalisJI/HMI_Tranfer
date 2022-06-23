using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HMITranfer
{
    public class Indicator
    {
        private static Indicator_dialog _indicatorDialog;
        public static Indicator_dialog Indicator_Dialog
        {
            get
            {
                if (_indicatorDialog != null)
                {
                    return _indicatorDialog;
                }
                else
                {
                    _indicatorDialog = new Indicator_dialog();
                    return _indicatorDialog;
                }
            }
            set => _indicatorDialog = value;
        }
        public Indicator()
        {

        }
        public static void BeingBusy()
        {
            Thread thread = new Thread(() =>
            {
                
                _ = Indicator_Dialog.ShowDialog();

            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public static void Finished()
        {
            try
            {

                _ = Indicator_Dialog.Dispatcher.BeginInvoke(new Action(() =>
                {
                    Indicator_Dialog.Close();
                }));


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
