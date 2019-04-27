using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{

    /// <summary>
    /// 父类是BaseStudentDecorator，爷爷类AbstractStudent
    /// </summary>
    public class StudentPayDecorator : BaseStudentDecorator
    {
        //表示父类的构造函数
        public StudentPayDecorator(AbstractStudent student) : base(student) { }

        public override void Study()
        {
            Console.WriteLine("付费");
            base.Study();
        }
    }
}
