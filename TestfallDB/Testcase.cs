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
        //Testfallnummer
        public int Nr { get; set; }
        //Name des Testfalls
        public string Testname { get; set; }
        //Vorbedingung
        public string Precondition { get; set; }
        //Geschwindigkeit
        public int Velocity { get; set; }
        //Erwartetets Ergebnis
        public string ExpectedResult { get; set; }
        //Status des Testfalls
        public TestStatus Status { get; set; }

        //bool ob Testfall schon getestet wurde
        public bool alreadyTested { get; set; }

        //enum der Testzustände
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
