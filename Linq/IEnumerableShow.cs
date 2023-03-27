using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Linq
{
    public class IEnumerableShow
    {
        public void show()
        {
            //select字句的引用
            /*  int[] array= { 1,2,3,4,5};
              var list = array.Select(item => item * item);
              foreach (var item in list)
              {
                  Console.WriteLine(item);
              }*/
            //where字句的引用
            /*int[] array = { 1, 2, 3, 4, 5 };
            var list = array.Where(item => item % 2 == 0).Select(item => item * item);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }*/
            //OrderBy()字句的引用
            // int[] array = {5,6, 4, 9, 6 };
            // var list = array.Where(item => item % 2 == 0).Select(item => item ).OrderBy(item=>item);
            //var list = array.Where(item => item % 2 == 0).Select(item => item ).OrderByDescending(item=>item);
            /*   string[] nums = { "张三", "李四", "王麻子", "张成伟", "周丙申", "栗颜家", "学子名", };
               var lists =nums.Where(item=>item.Length==2)
                   .Select(item=>item).OrderByDescending(item=>item.Substring(0,1));
               foreach (var item in lists)
               {
                   Console.WriteLine(item);
               }*/

            /*string[] nums = { "张三", "李四", "王麻子", "张成伟", "周丙申", "栗颜家", "学子名", };
            var lists = nums.Where(item => item.Length == 2)
                .Select(item => item).GroupBy(item => item.Substring(0, 1));
            foreach (var geroupitem in lists)
            {
                Console.WriteLine("-----------");
                Console.WriteLine("分组字段{0}", geroupitem.Key);
                foreach (var item in geroupitem)
                {
                    Console.WriteLine(item);
                }
            }*/
            //count 返回聚合项目的数目
            /*  Student stu1 = new Student() { StuId = 1001, StuName = "张三" };
              Student stu2 = new Student() { StuId = 1009, StuName = "李四" };
              Student stu3 = new Student() { StuId = 1013, StuName = "王麻子" };
              Student stu4 = new Student() { StuId = 1024, StuName = "张成伟" };
              Student stu5 = new Student() { StuId = 1005, StuName = "周丙申" };
              Student stu6 = new Student() { StuId = 1056, StuName = "栗颜家" };
              var stuList = new List<Student> { stu1, stu2, stu3, stu4, stu5, stu6 };
              var count1 = (from c in stuList
                            where c.StuId > 1010
                            select c).Count();
              var count2 = stuList.Where(c => c.StuId > 1010).Count();
              Console.WriteLine("count1={0},count2={1}",count1, count2);*/
            //聚合函数:max/min/agerage/sum函数的应用
            /*   Student stu1 = new Student() { StuId = 1001, StuAge = 21, StuName = "张三" };
               Student stu2 = new Student() { StuId = 1009, StuAge = 32, StuName = "李四" };
               Student stu3 = new Student() { StuId = 1013, StuAge = 26, StuName = "王麻子" };
               Student stu4 = new Student() { StuId = 1024, StuAge = 52, StuName = "张成伟" };
               Student stu5 = new Student() { StuId = 1005, StuAge = 62, StuName = "周丙申" };
               Student stu6 = new Student() { StuId = 1056, StuAge = 12, StuName = "栗颜家" };
               var stuList = new List<Student> { stu1, stu2, stu3, stu4, stu5, stu6 };
               var maxAge = (from c in stuList
                             select c.StuAge).Max();
               var minAge = (from c in stuList
                             select c.StuAge).Min();
               var aveAge = (from c in stuList
                             select c.StuAge).Average();
               var sumAge = (from c in stuList
                             select c.StuAge).Sum();
               Console.WriteLine("maxAge={0},minAge={1},ageAge={2},sumAge={3}", maxAge, minAge, aveAge, sumAge);*/
            //orderBy thenBy排序的输入
            /*   Student stu1 = new Student() { StuId = 1001, StuAge = 21, StuName = "张三" };
               Student stu2 = new Student() { StuId = 1009, StuAge = 32, StuName = "李四" };
               Student stu3 = new Student() { StuId = 1013, StuAge = 26, StuName = "王麻子" };
               Student stu4 = new Student() { StuId = 1024, StuAge = 52, StuName = "张成伟" };
               Student stu5 = new Student() { StuId = 1005, StuAge = 62, StuName = "周丙申" };
               Student stu6 = new Student() { StuId = 1056, StuAge = 12, StuName = "栗颜家" };
               var stuList = new List<Student> { stu1, stu2, stu3, stu4, stu5, stu6 };

               var stus1 = from s in stuList
                           orderby s.StuName, s.StuAge, s.StuId
                           select s;

               var stus2 = stuList
                   .OrderBy(s => s.StuName)
                   .ThenBy(s => s.StuAge)
                   .ThenBy(s => s.StuId)
                   .Select(p => p);
               foreach (var stus in stus1)
               {
                   Console.WriteLine("SName={0}", stus.StuName);
               }
               Console.WriteLine("------------------------");
               foreach (var item in stus2)
               {
                   Console.WriteLine("Sname{0},SAge{1}", item.StuName, item.StuAge);
               }*/
            Student stu1 = new Student() { StuId = 1001, StuAge = 21, TeacherId = 1, StuName = "张三" };
            Student stu2 = new Student() { StuId = 1009, StuAge = 32, TeacherId = 2, StuName = "李四" };
            Student stu3 = new Student() { StuId = 1013, StuAge = 26, TeacherId = 3, StuName = "王麻子" };
            Student stu4 = new Student() { StuId = 1024, StuAge = 52, TeacherId = 4, StuName = "张成伟" };
            Student stu5 = new Student() { StuId = 1005, StuAge = 62, TeacherId = 5, StuName = "周丙申" };
            Student stu6 = new Student() { StuId = 1056, StuAge = 12, TeacherId = 6, StuName = "栗颜家" };
            Student stu7 = new Student() { StuId = 1009, StuAge = 32, TeacherId = 2, StuName = "杨紫翔" };
            var stuList = new List<Student> { stu1, stu2, stu3, stu4, stu5, stu6, stu7 };

            Teacher tea1 = new Teacher() { TeacherId = 1, TeacherName = "王老师", TeacherCount = 1 };
            Teacher tea2 = new Teacher() { TeacherId = 2, TeacherName = "李老师", TeacherCount = 1 };
            Teacher tea3 = new Teacher() { TeacherId = 3, TeacherName = "荀老师", TeacherCount = 1 };
            Teacher tea4 = new Teacher() { TeacherId = 4, TeacherName = "严老师", TeacherCount = 1 };
            Teacher tea5 = new Teacher() { TeacherId = 5, TeacherName = "中老师", TeacherCount = 1 };
            Teacher tea6 = new Teacher() { TeacherId = 6, TeacherName = "择老师", TeacherCount = 1 };
            var teaList = new List<Teacher>() { tea1, tea2, tea3, tea4, tea5, tea6 };
            var query = from item in stuList
                        join titem in teaList on item.TeacherId equals titem.TeacherId
                        orderby item.StuId
                        where item.StuId > 4
                        select new { item.StuId, item.StuName, titem.TeacherName, titem.TeacherId };
            Console.WriteLine("------------------------");
            foreach (var items in query)
            {
                Console.WriteLine(items);
            }

            Console.WriteLine("简单的linq嵌套字查询");
            var tquery = (from item in teaList where item.TeacherName == "李老师" select item.TeacherId).FirstOrDefault();
            var querys = from item in stuList
                         where item.TeacherId == tquery
                         select item;
            foreach (var teaitem in querys)
            {
                Console.WriteLine($"{teaitem.StuId}--{teaitem.StuName}--{teaitem.TeacherId}--{teaitem.StuAge}");
            }
        }
    }
}
