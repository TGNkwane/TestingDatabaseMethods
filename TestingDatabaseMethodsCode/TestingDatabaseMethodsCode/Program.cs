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
            //1 Security levels:
            access.InsertSecuriyLevel("Standard", 1, "testing 12", "resting2");
            Console.ReadLine();
        }
    }
}
