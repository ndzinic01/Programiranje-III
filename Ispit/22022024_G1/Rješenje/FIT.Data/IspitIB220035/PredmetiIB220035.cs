using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB220035
{
    public class PredmetiIB220035
    {
        public int Id { get; set; }
        public string Naziv {  get; set; }
        public int SemestarId { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
