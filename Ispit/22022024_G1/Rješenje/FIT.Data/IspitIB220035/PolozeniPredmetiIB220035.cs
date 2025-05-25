using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB220035
{
    public class PolozeniPredmetiIB220035
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        public int Ocjena {  get; set; }
        public DateTime DatumPolaganja { get; set; }
        public string Napomena { get; set; }
    } 
}
