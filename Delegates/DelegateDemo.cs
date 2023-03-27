using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Delegates
{
    public class DelegateDemo
    {
        public delegate void NoReturnNoParamMethod();
        public delegate void NoReturnParamMethod(string Name);
        public delegate void NoReturnMoreParamMethod(string Name, int i);
        public delegate int ReturnNoParamMethod();
        public delegate int ReturnMoreParamMethod(string Name, int i);

        public void NoReturnNoParamMethodDemo()
        {
            Console.WriteLine("没有参数，没有返回值");
        }
        public void NoReturnParamMethodDemo(string Name)
        {
            Console.WriteLine($"有一个参数，没有返回值{Name}");
        }
        public void NoReturnMoreParamMethoddDemo(string Name, int i)
        {
            Console.WriteLine($"有很多参数，没有返回值{Name}");
        }
        public int ReturnNoParamMethodDemo()
        {
            Console.WriteLine("没有参数，有返回值");
            return 1;
        }
        public int ReturnMoreParamMethodDemo(string Name, int i)
        {
            Console.WriteLine($"有很多参数，有返回值{Name}---{i}");
            return 1;
        }

        //委托定义好了，方法定义好了，委托和方法怎么关联

        public void show()
        {
            {
                NoReturnNoParamMethod method1 = new NoReturnNoParamMethod(this.NoReturnNoParamMethodDemo);
                method1.Invoke();
            }
            {
                NoReturnParamMethod method2 = new NoReturnParamMethod(this.NoReturnParamMethodDemo);
                method2.Invoke("我有一个参数，我被调用了");
            }
            {
                NoReturnMoreParamMethod method3 = new NoReturnMoreParamMethod(this.NoReturnMoreParamMethoddDemo);
                method3.Invoke("我有两个参数", 2);
            }
            {
                ReturnNoParamMethod method4 = new ReturnNoParamMethod(this.ReturnNoParamMethodDemo);
                method4.Invoke();
            }
            {
                ReturnMoreParamMethod method5 = new ReturnMoreParamMethod(this.ReturnMoreParamMethodDemo);
                method5.Invoke("我有两个参数,同时有返回值", 3);
            }
        }
    }
}
