using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        public static void Main(string[] args)
        {
            int? EntryAllowed = null;

            int NumberOfGuests = 10;

            if (EntryAllowed == null)
            {
                Console.WriteLine("No one is allowed at the moment");
            }
            else if (EntryAllowed != null)
            {
                NumberOfGuests = (int)EntryAllowed;
                Console.WriteLine("We can allow {0}", NumberOfGuests);
            }


        }
    }
}
