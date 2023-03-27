using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Attributes
{
    [AttributeDefineDemo(18)]
    public class AttributeDefineExample
    {
        [AttributeDefineDemo(20)]
        public void show()
        {
            Console.WriteLine("年龄合法，执行通过");
        }
    }
}
