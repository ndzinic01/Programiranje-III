using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB220035
{
    public class CertifikatiGodineIB220035
    {
        public int Id { get; set; }
        public int CertifikatId { get; set; }
        public CertifikatiIB220035 Certifikat { get; set; }
        public string Iznos { get; set; }
        public string Godina { get; set; }
    }
}
