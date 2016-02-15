using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IInsureMasterDA test = new InsureMasterDA();
            Console.WriteLine("Test");
            var task = new Task(async () =>
            {   
                var result = await test.GetAll();
                Console.WriteLine("Insure Master Count", result.Count());
            });            
            Console.WriteLine(task.Status.ToString());
            // This just prevents the console app from exiting before the async work completes.
            
            Task.WaitAll(task);
        }
    }
}
