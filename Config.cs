using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMITranfer
{
    public class Config
    {
        public string IP { get; set; } = "192.168.0.10";
        public short Rack { get; set; } = 1;
        public short Slot { get; set; } = 0;

    }
}
