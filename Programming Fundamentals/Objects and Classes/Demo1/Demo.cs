using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class Demo1
    {
        public static void Main()
        {
             var cat1 = new Cat();
            var cat2 = new Cat();
            var cat3 = new Cat();

            cat1.Name = "Pesho";
            cat1.Age = 5;

            cat2.Name = "Gosho";
            cat2.Age =3;

            cat3.Name = "Maria";
            cat3.Age = 1;


            foreach (var item in cat())
            {

            }
            Console.WriteLine(cat.Name);
            Console.WriteLine(cat.Age);

        }
    }
}
