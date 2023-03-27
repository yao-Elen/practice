using ConsoleApp4.Attributes;
using ConsoleApp4.Delegates;
using ConsoleApp4.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    /// <summary>
    /// 
    ///委托事件：什么叫事件？事件就是委托的安全版本，第一点--在定义事件的外部，他是不能使用=号
    ///来操作，只能用+=，第二点，在定义事件类的外部不能调用事件，另外事件就是在委托前面增加
    ///一个event关键字
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
        /*    IEnumerableShow enumerableShow = new IEnumerableShow();
            enumerableShow.show();*/

            /*
                        void DoSthWithLiang(Func<string, string> do_sth)
                        {
                            var name = "向阳";
                            var result = do_sth(name);
                            Console.WriteLine(result);
                        }
                        DoSthWithLiang(name => name + "喜欢SF");

                        var list = new List<Person>()
                        {
                            new Person(){Age=12,Name="wangsan"},
                            new Person(){Age=13,Name="lidan"},
                            new Person(){Age=14,Name="huojia"},
                            new Person(){Age=15,Name="kaixin"},
                            new Person(){Age=22,Name="wangsx"}

                        };*/
            /*var s = list.Where(p => p.Age < 18)
                .ToList();
            foreach (var p in s)
            {
                Console.WriteLine(p.Name);
            }*/
            // .ForEach(c =>Write(c.Name));
            DelegateDemo delegateDemo = new DelegateDemo();
            delegateDemo.show();

            AttributeDefineMain.main();

            Console.ReadLine();
        }
    }
    /* public class Person
     {
         public int Age { get; set; }
         public string? Name { get; set; }
     }*/
}
