using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class HasTardisKey : IDoctor
    {
        public bool isDoctor()
        {
            Console.WriteLine("He has the key, he is the Doctor!");
            return true;
        }

        public bool isNotDoctor()
        {
            Console.WriteLine("He can't be trusted, run!");
            return false;
        }
    }
}
