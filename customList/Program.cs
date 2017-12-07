using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customList
{
    class Program
    {
        static void Main(string[] args)
        {
/*                       MyList<TestClass> myListInstance = new MyList<TestClass>();

                        myListInstance.Add(new TestClass(33, "Dude Guy"));
                        myListInstance.Add(new TestClass(33, "Dude Guy"));
                        myListInstance.Add(new TestClass(54, "Tony Stark"));
*/

            MyList<int> myListInstance = new MyList<int>();

            myListInstance.Add(1);
            myListInstance.Add(2);
            myListInstance.Add(3);
            myListInstance.Add(4);
            myListInstance.Add(5);
            myListInstance.Add(6);
            myListInstance.Add(7);
            myListInstance.Add(8);

            MyList<int> myListInstance2 = new MyList<int>();
            myListInstance2.Add(1);
            myListInstance2.Add(8);
            myListInstance2.Add(64);

            MyList<int> subtractedList = myListInstance - myListInstance2;
            Console.WriteLine(subtractedList.ToString());
            Console.ReadKey();
        }
    }
}
