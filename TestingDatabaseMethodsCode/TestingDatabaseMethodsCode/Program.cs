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
            //Security Levels
            //1 Security levels: Standard
            //access.InsertSecuriyLevel("Standard", 1, "MON-FRI-8AM-5PM", "MON-FRI-8AM-5PM");
            //2 Security levels: Premium
            //access.InsertSecuriyLevel("Premium", 1, "MON-SAT-5AM-9PM", "MON-SAT-5AM-9PM");
            //3 Security levels: Ultra
            //access.InsertSecuriyLevel("Ultra", 1, "MON-SUN-24HRS", "MON-SUN-24HRS");

            //Service Levels
            //access.InsertServiceLevel("Standard Plan", "50% of Total cost required for opt out", 6, 10, 1, 1);
            //issue accepting decimals 4.5
            //access.InsertServiceLevel("Standard Plus Plan", "50% of Total cost required for opt out", 5, 9, 1, 2);

            //access.InsertServiceLevel("Premium Plan", "60% of Total cost required for opt out", 4, 8, 1, 3);

            //Services

            //access.InsertService("Yearly Maintenance", "Heavy Machinery", "Transport and material", 1);
            //access.InsertService("Emergency Maintenance", "Production line equpment", "Transport and material", 1);

            ////Packages
            //access.InsertPackage("Office Equipment","1,2", "3,2");
            //access.InsertPackage("Office Equipment", "2,3", "1,3");

            // Contracts
            // CANNOT CREATE THIS WITH JUST IDS as a package might span acroess ids 
            // object relational impedance mismatch -- a list of services vs a table 
            access.InsertContract(1,2);
            access.InsertContract(2,1);

            Console.ReadLine();
            
        }
    }
}
