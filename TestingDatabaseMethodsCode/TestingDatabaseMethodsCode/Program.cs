using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingDatabaseMethodsCode.DataAccessLayer;

namespace TestingDatabaseMethodsCode
{
    class Program
    {
        static void Main(string[] args)
        {
            ContractMaintenanceAccess access = new ContractMaintenanceAccess();
            //1 Security levels:
            access.InsertSecuriyLevel("Standard", 1, "MON-FRI-8AM-10PM", "MON-FRI-8AM-5PM");
            Console.ReadLine();
        }
    }
}
