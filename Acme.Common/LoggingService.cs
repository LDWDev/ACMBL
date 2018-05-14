using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Acme.Common
{
    public interface ILoggable
    {
        string Log();
    }

    public class LoggingService
    {
        public static void WriteToFile(List<ILoggable> ChangedItems)
        {
            foreach (var item in ChangedItems)
            {
                Console.WriteLine(item.Log());
                Console.ReadLine();
            }
        }
    }
}
