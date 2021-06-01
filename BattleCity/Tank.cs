using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCity
{
     abstract class Tank
    {
        private int body;
        public int Body { get; set; }

        private int tower;
        public int Tower { get; set; }

        private int gun;
        public int Gun { get; set; }

        int chassis;
        public int Chassis { get; set; }
    }
}
