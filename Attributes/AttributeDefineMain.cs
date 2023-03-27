using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp4.Attributes
{
    public class AttributeDefineMain
    {
        public static void main()
        {
            AttributeDefineExample model = new AttributeDefineExample();
            Type type = model.GetType();

            MethodInfo method = type.GetMethod("show");
            if (type.IsDefined(typeof(AttributeDefineDemo), true)){
                var attribute = type.GetCustomAttribute<AttributeDefineDemo>();
                if (attribute.IsAge())
                {
                    model.show();
                }
            }
        }
    }
}
