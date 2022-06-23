using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using S7.Net;

namespace HMITranfer.ViewModel
{
    public class MainScreen_ViewModel:BaseViewModel
    {


        #region Model
        private BaseViewModel _view;   

        public BaseViewModel SelectedViewModel
        {
            get => _view;
            set => SetProperty(ref _view, value, nameof(SelectedViewModel));
        }

        private static MainScreen_ViewModel _ViewModel;
        /// <summary>
        /// SingleTon
        /// </summary>
        public static MainScreen_ViewModel INS_MainScreenViewModel
        {
            get
            {
                if (_ViewModel != null)
                {
                    return _ViewModel;
                }
                else
                {
                    _ViewModel = new MainScreen_ViewModel();
                    return _ViewModel;
                }
            }
            set => _ViewModel = value;
        }



        private string _btnName = "I/O LIST";

        public string BtnName
        {
            get => _btnName;
            set => SetProperty(ref _btnName, value, nameof(BtnName));
        }


        private string _manuxst = "MANU X ST";

        public string MANU_X_ST_NAME
        {
            get => _manuxst;
            set => SetProperty(ref _manuxst, value, nameof(MANU_X_ST_NAME));
        }

        private string _manuYst = "MANU Y ST";

        public string MANU_Y_ST_NAME
        {
            get => _manuYst;
            set => SetProperty(ref _manuYst, value, nameof(MANU_Y_ST_NAME));
        }

        private string _manuz1st = "MANU Z1 ST";

        public string MANU_Z1_ST_NAME
        {
            get => _manuz1st;
            set => SetProperty(ref _manuz1st, value, nameof(MANU_Z1_ST_NAME));
        }

        private string _manuz2st = "MANU Z2 ST";

        public string MANU_Z2_ST_NAME
        {
            get => _manuz2st;
            set => SetProperty(ref _manuz2st, value, nameof(MANU_Z2_ST_NAME));
        }


        private string _IP;

        public string PLC_IP
        {
            get => _IP;
            set => SetProperty(ref _IP,value,nameof(PLC_IP));
        }


        private short _rack;

        public short PLC_Rack
        {
            get => _rack;
            set => SetProperty(ref _rack, value, nameof(PLC_Rack));
        }


        private short _slot;

        public short PLC_Slot
        {
            get => _slot;
            set => SetProperty(ref _slot, value, nameof(PLC_Slot));
        }

        private bool _visible;

        public bool Visi
        {
            get => _visible;
            set => SetProperty(ref _visible, value, nameof(Visi));
        }

        private string _editname = "EDIT";

        public string Btn_edtiname
        {
            get => _editname;
            set => SetProperty(ref _editname, value, nameof(Btn_edtiname));
        }

        #endregion


        #region Commmand Switch Page
        public ICommand Loaded { get; set; }
        public ICommand Unloaded { get; set; }
        public ICommand MANU_PageCommand { get; set; }
        public ICommand AUTO_PageCommnad { get; set; }
        public ICommand Home_PageCommand { get; set; }
        public ICommand IO_LIST_PageCommand { get; set; }
        public ICommand ALARM_PageCommand { get; set; }

        public ICommand MANUAL_Y_ST_PageCommand { get; set; }
        public ICommand MANUAL_Z1_ST_PageCommand { get; set; }
        public ICommand MANUAL_Z2_ST_PageCommand { get; set; }

        public ICommand INPUT_LIST_1_PageCommand { get; set; }
        public ICommand INPUT_LIST_2_PageCommand { get; set; }
        public ICommand INPUT_LIST_3_PageCommand { get; set; }

        public ICommand OUTPUT_LIST_1PageCommand { get; set; }
        public ICommand OUTPUT_LIST_2_PageCommand { get; set; }

        public ICommand To_INPUT_LIST_2_PageCommand { get; set; }
        public ICommand To_INPUT_LIST_3_PageCommand { get; set; }

        public ICommand To_INPUT_LIST_1_PageCommand { get; set; }

        public ICommand To_OUTPUT_LIST_1_PageCommand { get; set; }
        public ICommand To_OUTPUT_LIST_2_PageCommand { get; set; }

        #endregion

        #region Command Excute
        public  ICommand MANU_AUTOXST_Command { get; set; }
        public  ICommand MANU_AUTOYST_Command { get; set; }
        public  ICommand MANU_AUTOZ1ST_Command { get; set; }
        public  ICommand MANU_AUTOZ2ST_Command { get; set; }


        public ICommand Start_Command { get; set; }
        public ICommand Stop_Command { get; set; }





        public ICommand Edit { get; set; }
        public ICommand Save { get; set; }

        #endregion




        #region Variable

        public static Plc S71200;
        #region ViewModel Var
        MainScreen_ViewModel main;
        private MANU_ViewModel MANU_ViewModel = MANU_ViewModel.INS_MANU_ViewModel;
        public MANUAL_Y_ST_ViewModel MANUAL_Y_ST_ViewModel = MANUAL_Y_ST_ViewModel.INS_MANUAL_Y_ST_ViewModel;
        public MANUAL_Z1_ST_ViewModel MANUAL_Z1_ST_ViewModel = MANUAL_Z1_ST_ViewModel.INS_MANUAL_Z1_ST_ViewModel;
        public MANUAL_Z2_ST_ViewModel MANUAL_Z2_ST_ViewModel = MANUAL_Z2_ST_ViewModel.INS_MANUAL_Z2_ST_ViewModel;
        public ALARM_ViewModel ALARM_ViewModel = ALARM_ViewModel.INS_ALARM_ViewModel;
        public AUTO_ViewModel AUTO_ViewModel = AUTO_ViewModel.INS_AUTO_ViewModel;
        public INPUT_LIST_1_ViewModel INPUT_LIST_1_ViewModel = INPUT_LIST_1_ViewModel.INS_INPUT_LIST_1_ViewModel;
        public INPUT_LIST2_ViewModel INPUT_LIST2_ViewModel = INPUT_LIST2_ViewModel.INS_INPUT_LIST2_ViewModel;
        public INPUT_LIST_3_ViewModel INPUT_LIST_3_ViewModel = INPUT_LIST_3_ViewModel.INS_INPUT_LIST_3_ViewModel;
        public OUTPUT_1_ViewModel OUTPUT_1_ViewModel = OUTPUT_1_ViewModel.INS_OUTPUT_1_ViewModel;
        public OUTPUT_LIST_2_ViewModel OUTPUT_LIST_2_ViewModel = OUTPUT_LIST_2_ViewModel.INS_OUTPUT_LIST_2_ViewModel;
        #endregion
        #endregion
        /// <summary>
        /// Contructor
        /// </summary>
        public MainScreen_ViewModel()
        {
            if (main == null) 
            {
                main = this;
                main.SelectedViewModel = this;
            }
            
            Loaded = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                
                PLC_IP = Systemconfig.Config.IP;
                PLC_Rack = Systemconfig.Config.Rack;
                PLC_Slot = Systemconfig.Config.Slot;
                if (S71200 == null)
                {
                    Indicator.BeingBusy();
                    try
                    {
                        S71200 = new Plc(CpuType.S71200, Systemconfig.Config.IP, Systemconfig.Config.Rack, Systemconfig.Config.Slot);
                        if (!S71200.IsConnected)
                        {
                            S71200.Open();
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                    Indicator.Finished();
                }
               
            });
            Unloaded = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                Systemconfig.Config.IP = PLC_IP;
                Systemconfig.Config.Rack = PLC_Rack;
                Systemconfig.Config.Slot = PLC_Slot;
                Systemconfig.UpdateData(Systemconfig.Config);

            });
            Edit = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                string a = (string)p;
                if (a == "CANCEL")
                {
                    Visi = false;
                    Btn_edtiname = "EDIT";
                }
                else if(a == "EDIT")
                {
                    Visi = true;
                    Btn_edtiname = "CANCEL";
                }
                
            });

            Save = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                Systemconfig.Config.IP = PLC_IP;
                Systemconfig.Config.Rack = PLC_Rack;
                Systemconfig.Config.Slot = PLC_Slot;
                Systemconfig.UpdateData(Systemconfig.Config);

                Visi = false;
                Btn_edtiname = "EDIT";
            });
            MANU_PageCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                main.SelectedViewModel = MANU_ViewModel;
            });

            Home_PageCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                main.SelectedViewModel = this;
            });
            AUTO_PageCommnad = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                main.SelectedViewModel = AUTO_ViewModel;
            });
            IO_LIST_PageCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                string a = (string)p;
                if (a == "I/O LIST")
                {
                    BtnName = "OUT LIST";
                    main.SelectedViewModel = INPUT_LIST_1_ViewModel;
                }
                else if (a == "OUT LIST")
                {
                    BtnName = "I/O LIST";
                    main.SelectedViewModel = OUTPUT_1_ViewModel;
                }
                
            });
            ALARM_PageCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                main.SelectedViewModel = ALARM_ViewModel;
            });

            MANUAL_Y_ST_PageCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                main.SelectedViewModel = MANUAL_Y_ST_ViewModel;
            });

            MANUAL_Z1_ST_PageCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                main.SelectedViewModel = MANUAL_Z1_ST_ViewModel;
            });

            MANUAL_Z2_ST_PageCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                main.SelectedViewModel = MANUAL_Z2_ST_ViewModel;
            });

            INPUT_LIST_1_PageCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BtnName = "OUT LIST";
                main.SelectedViewModel = INPUT_LIST_1_ViewModel;
            });
            INPUT_LIST_2_PageCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BtnName = "OUT LIST";
                main.SelectedViewModel = INPUT_LIST2_ViewModel;
            });
            INPUT_LIST_3_PageCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BtnName = "OUT LIST";
                main.SelectedViewModel = INPUT_LIST_3_ViewModel;
            });
            OUTPUT_LIST_1PageCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BtnName = "I/O LIST";
                main.SelectedViewModel = OUTPUT_1_ViewModel;
            });
            OUTPUT_LIST_2_PageCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BtnName = "I/O LIST";
                main.SelectedViewModel = OUTPUT_LIST_2_ViewModel;
            });
            To_INPUT_LIST_2_PageCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BtnName = "OUT LIST";
                main.SelectedViewModel = INPUT_LIST2_ViewModel;
            });
            To_INPUT_LIST_3_PageCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BtnName = "OUT LIST";
                main.SelectedViewModel = INPUT_LIST_3_ViewModel;
            });
            To_INPUT_LIST_1_PageCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BtnName = "OUT LIST";
                main.SelectedViewModel = INPUT_LIST_1_ViewModel;
            });
            To_OUTPUT_LIST_1_PageCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BtnName = "I/O LIST";
                main.SelectedViewModel = OUTPUT_1_ViewModel;
            });

            To_OUTPUT_LIST_2_PageCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BtnName = "I/O LIST";
                main.SelectedViewModel = OUTPUT_LIST_2_ViewModel;
            });



            Start_Command = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
            
            });

            Stop_Command = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
            
            });


            MANU_AUTOXST_Command = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (S71200 == null)
                {
                    return;
                }

                if (S71200.IsConnected)
                {
                    
                    bool a = (bool)S71200.Read("M2.2");
                    if (a)
                    {
                        MANU_X_ST_NAME = "MANU X ST";
                        S71200.Write("M2.2", false);
                    }
                    else
                    {
                        MANU_X_ST_NAME = "AUTO X ST";
                        S71200.Write("M2.2", true);
                    }
                }
            });
            MANU_AUTOYST_Command = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (S71200 == null)
                {
                    return;
                }
                if (S71200.IsConnected)
                {

                    bool a = (bool)S71200.Read("M2.3");
                    if (a)
                    {
                        MANU_Y_ST_NAME = "MANU Y ST";
                        S71200.Write("M2.3", false);
                    }
                    else
                    {
                        MANU_Y_ST_NAME = "AUTO Y ST";
                        S71200.Write("M2.3", true);
                    }
                }
            });
            MANU_AUTOZ1ST_Command = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (S71200 == null)
                {
                    return;
                }
                if (S71200.IsConnected)
                {

                    bool a = (bool)S71200.Read("M70.0");
                    if (a)
                    {
                        MANU_X_ST_NAME = "MANU Z1 ST";
                        S71200.Write("M70.0", false);
                    }
                    else
                    {
                        MANU_X_ST_NAME = "AUTO Z1 ST";
                        S71200.Write("M70.0", true);
                    }
                }
            });
            MANU_AUTOZ2ST_Command = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (S71200 == null)
                {
                    return;
                }
                if (S71200.IsConnected)
                {

                    bool a = (bool)S71200.Read("M70.1");
                    if (a)
                    {
                        MANU_X_ST_NAME = "MANU Z2 ST";
                        S71200.Write("M70.1", false);
                    }
                    else
                    {
                        MANU_X_ST_NAME = "AUTO Z2 ST";
                        S71200.Write("M70.1", true);
                    }
                }
            });
        }
    }
}
