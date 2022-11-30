using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryModels;
namespace InventorySimulation
{

    class fileHandler
    {
        private SimulationSystem system;
        public SimulationSystem ReadTestCase(string testCasePath)
        {
            system = new SimulationSystem();
            Stream stream = File.Open(testCasePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var sr = new StreamReader(stream);
            string ln;
            while ((ln = sr.ReadLine()) != null)
            {
                if (ln.Equals("OrderUpTo"))
                {
                    system.OrderUpTo = Int32.Parse(sr.ReadLine());
                }
                else if (ln.Equals("ReviewPeriod"))
                {
                    system.ReviewPeriod = Int32.Parse(sr.ReadLine());
                }
                else if (ln.Equals("StartInventoryQuantity"))
                {
                    system.StartInventoryQuantity = Int32.Parse(sr.ReadLine());
                }
                else if (ln.Equals("StartLeadDays"))
                {
                    system.StartLeadDays = Int32.Parse(sr.ReadLine());
                }
                else if (ln.Equals("StartOrderQuantity"))
                {
                    system.StartOrderQuantity = Int32.Parse(sr.ReadLine());
                }
                else if (ln.Equals("NumberOfDays"))
                {
                    system.NumberOfDays = Int32.Parse(sr.ReadLine());
                }
                else if (ln.Equals("DemandDistribution"))
                {
                    while (!String.IsNullOrEmpty(ln = sr.ReadLine()))
                    {
                        ln = ln.Replace(" ", string.Empty);
                        string[] values = ln.Split(',');
                        int value = int.Parse(values[0]);
                        decimal probability = Decimal.Parse(values[1]);
                        system.DemandDistribution.Add(new Distribution(value, probability));
                    }
                }
                else if (ln.Equals("LeadDaysDistribution"))
                {

                    while (!String.IsNullOrEmpty(ln = sr.ReadLine()))
                    {
                        ln = ln.Replace(" ", string.Empty);
                        string[] values = ln.Split(',');
                        int time = Int32.Parse(values[0]);
                        decimal probability = Decimal.Parse(values[1]);
                        system.LeadDaysDistribution.Add(new Distribution(time, probability));
                    }
                }
            }
            return system;
        }
    }
}

