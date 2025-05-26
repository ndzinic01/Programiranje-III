using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB220035
{
    public class RazmjeneIB220035
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int UniverzitetId { get; set; }
        public UniverzitetiIB220035 Univerzitet { get; set; }
        public DateTime PocetakRazmjene { get; set; }
        public DateTime KrajRazmjene { get; set; }
        public string ECTS { get; set; }
        public bool Okoncana { get; set; }
    }
}