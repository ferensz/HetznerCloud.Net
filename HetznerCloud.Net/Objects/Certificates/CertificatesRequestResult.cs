using System.Collections.Generic;
using HetznerCloud.Net.Core;

namespace HetznerCloud.Net.Objects.Certificates
{
    public class CertificatesRequestResult
    {
        public List<Certificate> Certificates { get; set; }
        public Meta Meta { get; set; }
    }
}