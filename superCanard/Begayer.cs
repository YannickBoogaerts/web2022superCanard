using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superCanard
{
    public class Begayer : ComportementCancan
    {
        public Begayer(ComportementCancan MonCri)
        {
            this.MonCri = MonCri;
        }

        public ComportementCancan MonCri { get; private set; }

        

        public void Cancanner()
        {
            MonCri.Cancanner();
            MonCri.Cancanner();
        }
    }
}
