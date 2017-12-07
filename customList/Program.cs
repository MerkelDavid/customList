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
                        MyList<TestClass> myListInstance = new MyList<TestClass>();

                        myListInstance.Add(new TestClass(33, "Dude Guy"));
                        myListInstance.Add(new TestClass(33, "Dude Guy"));
                        myListInstance.Add(new TestClass(54, "Tony Stark"));

/*            MyList<char> myListInstance = new MyList<char>();

            myListInstance.Add('a');
            myListInstance.Add('b');
            myListInstance.Add('c');
            myListInstance.Add('d');
            myListInstance.Add('e');
            myListInstance.Add('f');
            myListInstance.Add('g');
            myListInstance.Add('h');
*/
            Console.WriteLine(myListInstance.ToString());
            Console.ReadKey();
        }
    }
}
