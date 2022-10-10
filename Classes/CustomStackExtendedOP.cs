using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class CustomStackExtendedOP
    {
        public static void DisplayAllInternsNameAndId(CustomStack<IInterns> stack)
        {
            while (stack.Count() > 0)
            {
                Console.WriteLine(stack.Pop().NameId);
            }
        }
    }
}
