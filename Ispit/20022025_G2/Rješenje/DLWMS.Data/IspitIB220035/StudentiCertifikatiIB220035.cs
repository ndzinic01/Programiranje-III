using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB220035
{
    public class StudentiCertifikatiIB220035
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CertifikatiGodineId { get; set; }
        public CertifikatiGodineIB220035 CertifikatiGodine { get; set; }
    }
}
