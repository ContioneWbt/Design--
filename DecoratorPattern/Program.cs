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
                    AbstractStudent student = new StudentVip() {Id = 20,Name = "候鸟" };
                    student = new StudentFirstDecorator(student);//里氏替换 引用替换一下
                    student = new StudentSecondDecorator(student);
                    student = new StudentThirdDecorator(student);
                    student = new StudentFourthDecorator(student);
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
