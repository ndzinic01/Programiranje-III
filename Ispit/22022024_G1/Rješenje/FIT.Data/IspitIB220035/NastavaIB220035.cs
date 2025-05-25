using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB220035
{
    public class NastavaIB220035
    {
        public int Id { get; set; }
        public int ProstorijaId { get; set; }
        public ProstorijeIB220035 Prostorija { get; set; }
        public int PredmetId { get; set; }
        public PredmetiIB220035 Predmet {  get; set; }
        public string Vrijeme { get; set; }
        public string Dan {  get; set; }
        public string Oznaka { get; set; }
    }
}
