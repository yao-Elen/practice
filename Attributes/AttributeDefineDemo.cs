using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Attributes
{
    /// <summary>
    /// 自定义特性
    /// 功能：年龄限制的特性
    /// 第一：他必须是一个类
    /// 第二：他必须继承Attribute[间接]
    /// 第三：必须有符合业务需求的功能【就是内部有一些方法】
    /// </summary>
    public class AttributeDefineDemo : Attribute
    {
        public int Age;

        public AttributeDefineDemo(int age)
        {
            this.Age = age;
        }
        public bool IsAge()
        {
            return this.Age > 18 ? true : false;
        }
    }
}
