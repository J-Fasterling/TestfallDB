using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestfallDB
{
    public class CarConfiguration
    {
        //Liste der fahrzeugspezifischen Bauteile
        public List<Components> ConfigurationList = new List<Components>();

        //Liste aller Testfälle für dieses Fahrzeug
        public List<Testcase> CarspecificTests = new List<Testcase>();

        //Liste aler Testfälle die getestet werden können
        public List<Testcase> testcasesToShow = new List<Testcase>();

        //Anzahl an getesteten Tests
        public int testCnt { get; set; }
        //Anzahl zu testende Tests
        public int toTest { get; set; }

        public CarConfiguration()
        {
            testCnt = 0;
        }
    }
}
