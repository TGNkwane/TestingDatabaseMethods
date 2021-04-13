using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDatabaseMethodsCode
{
    class Program
    {
        static void Main(string[] args)
        {
            ContractMaintenanceAccess access = new ContractMaintenanceAccess();
            //1 Security levels: Standard
            access.InsertSecuriyLevel("Standard", 1, "MON-FRI-8AM-5PM", "MON-FRI-8AM-5PM");
            // 2 Security levels: Premium
            access.InsertSecuriyLevel("Premium", 1, "MON-FRI-5AM-12AM", "MON-FRI-5AM-12AM");
            // 3 Security levels: Ultra
            access.InsertSecuriyLevel("Ultra", 1, "MON-SUN-24HRS", "MON-SUN-24HRS");
            Console.ReadLine();
        }
    }
}
