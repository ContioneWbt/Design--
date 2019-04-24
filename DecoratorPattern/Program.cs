using DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    ///  装饰器模式，结构型设计模式巅峰之作，组合+继承
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("*********************************************");
                {
                    AbstractStudent student = new StudentVip()
                    {
                        Id = 20,
                        Name = "候鸟"
                    };
                    AbstractStudent decorator4 = new StudentVideoDecorator(student);//里氏替换
                    student = new StudentVideoDecorator(student);//引用替换一下
                    student = new StudentHomeworkDecorator(student);
                    student = new StudentCommentDecorator(student);
                    student = new StudentVideoDecorator(student);
                    student = new StudentUpdateDecorator(student);
                    student = new StudentNotices(student);
                    student.Study();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
