using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListTests
{
    class TestClass : IComparable
    {
        int number;
        string name;
      
        public TestClass(int number,string name)
        {
            this.number = number;
            this.name = name;
        }

        public int CompareTo(object obj)
        {
            return number.CompareTo(obj);
        }
    }
}
