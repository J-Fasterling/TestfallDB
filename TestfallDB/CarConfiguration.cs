using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestfallDB
{
    public class CarConfiguration
    {
        public List<Components> ConfigurationList = new List<Components>();

        public List<Testcase> CarspecificTests = new List<Testcase>();

        public List<Testcase> testcasesToShow = new List<Testcase>();

        public int testCnt { get; set; }
        public int toTest { get; set; }

        public CarConfiguration()
        {
            testCnt = 0;
        }
    }
}
