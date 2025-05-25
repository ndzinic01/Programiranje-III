using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB220035
{
    public class PrisustvoIB220035
    {
        public int Id { get; set; }
        public int NastavaId { get; set; }
        public NastavaIB220035 Nastava { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
