using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestfallDB
{
    [Serializable()]
    public class Components
    {
        public string Component { get; set; }
        public int Nr { get; set; }


        public Components() { }

        public Components(string component, int nr)
        {
            this.Component = component;
            this.Nr = nr;
        }

        public Components(string component)
        {
            this.Component = component;
        }
    }
}
