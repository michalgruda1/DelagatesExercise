using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool success = false;
            decimal budget = 10000m;

            MarketingDepertment dept = new MarketingDepertment();
            success = dept.RunMarketingCampaign(budget);

            Console.WriteLine("The new marketing campaign has been a {0}", success ? "success" : "failure");
            Console.Read();
        }
    }
}
