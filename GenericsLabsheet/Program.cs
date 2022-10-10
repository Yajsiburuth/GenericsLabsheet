using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLabsheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*            CustomStack<string> stack = new CustomStack<string>();

            stack.Push("Jedi-x");
            stack.Pop();
            stack.Push("Jedi");

            stack.Push("Skillslab");

            while(stack.Count() > 0)
            {
                Console.WriteLine(stack.Pop());
            }*/

            CustomStack<IInterns> jediStack = new CustomStack<IInterns>();
            Jedi jedi1 = new Jedi("James", 123);
            Jedi jedi2 = new Jedi("Jane", 1234);
            Jedi jedi3 = new Jedi("Tim", 12345);

            jediStack.Push(jedi1);
            jediStack.Push(jedi2);
            jediStack.Push(jedi3);
            CustomStackExtendedOP.DisplayAllInternsNameAndId(jediStack);

            Console.ReadLine();


            //Contravariance, Covariance
            // Generic methods


        }
    }
}
