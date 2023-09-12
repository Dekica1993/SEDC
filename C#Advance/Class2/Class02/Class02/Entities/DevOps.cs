using Class02.Entities.Interfacess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.Entities
{
    public class DevOps : Human,IDevOps
    {
        public bool AWCertified { get; set; }
        public bool AzureCertified { get; set; }
        public DevOps(string fullName, int age, long phone, bool AWCertified, bool AzureCertified) : base(fullName, age, phone)
        {
            this.AWCertified = AWCertified;
            this.AzureCertified = AzureCertified;
        }

        public void Code ()
        {
            Console.WriteLine("The dev ops guy is coding, but not like the developer one");
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - aws Certified: {(AWCertified ? "yes": "no")} Azure certified: {(AzureCertified ? "yes": "no")}";
             
        }

        public bool CheckInfrastructure(int status)
        {
            List<int> okStatuses = new List<int>() { 200, 202, 204 };
            if (okStatuses.Contains(status))
            {
                return true;
            }
            return false;

        }
    }
}
