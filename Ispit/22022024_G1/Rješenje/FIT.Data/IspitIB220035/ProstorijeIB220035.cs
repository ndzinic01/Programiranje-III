using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB220035
{
    public class ProstorijeIB220035
    {
        public int Id { get; set; }
        public string Naziv {  get; set; }
        public string Oznaka { get; set; }
        public byte[] Logo { get; set; }
        public string Kapacitet { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
