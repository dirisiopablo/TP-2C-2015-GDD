using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Entity {
    class Usertest {

        public String a1 { get; set; }
        public int a2 { get; set; }
        private int a3 { get; set; }

        public Usertest(string a1, int a2, int a3) {
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;
        }

    }
}
