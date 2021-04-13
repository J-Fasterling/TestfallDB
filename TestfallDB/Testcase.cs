using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestfallDB
{
    class Testcase
    {
        public string Testname { get; set; }
        public string Precondition { get; set; }
        public int Velocity { get; set; }
        public string ExpectedResult { get; set; }


        public List<Testcase> TestcaseList = new List<Testcase>();


        public Testcase() { }
        public Testcase(string name, string precondition, int velocity, string result)
        {
            this.Testname = name;
            this.Precondition = precondition;
            this.Velocity = velocity;
            this.ExpectedResult = result;
        }
    }
}
