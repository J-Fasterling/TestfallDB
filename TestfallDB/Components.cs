using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestfallDB
{
    class Components
    {
        public string Component { get; set; }

        public List<Components> ComponentList = new List<Components>();

        public Components() { }

        public Components(string component)
        {
            this.Component = component;
        }
    }
}
