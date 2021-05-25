using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestfallDB
{
    [Serializable()]
    public class Testcase
    {
        public int Nr { get; set; }
        public string Testname { get; set; }
        public string Precondition { get; set; }
        public int Velocity { get; set; }
        public string ExpectedResult { get; set; }
        public TestStatus Status { get; set; }

        public bool alreadyTested { get; set; }

        public enum TestStatus 
        { 
            notTested, 
            i_O, 
            n_i_O, 
            n_D
        };

        public Testcase() 
        {
            alreadyTested = false;
        }
        public Testcase(int nr, string name, string precondition, int velocity, string result)
        {
            this.Nr = nr;
            this.Testname = name;
            this.Precondition = precondition;
            this.Velocity = velocity;
            this.ExpectedResult = result;
            this.Status = TestStatus.notTested;
        }
    }
}
