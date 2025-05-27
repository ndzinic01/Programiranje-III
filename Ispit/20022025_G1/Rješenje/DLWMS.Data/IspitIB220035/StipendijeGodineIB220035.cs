using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB220035
{
    public class StipendijeGodineIB220035
    {
        public int Id { get; set; }
        public int StipendijaId { get; set; }
        public StipendijeIB220035 Stipendija { get; set; }
        public string Godina {  get; set; }
        public string Iznos { get; set; }
    }
}
