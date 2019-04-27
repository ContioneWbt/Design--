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
    public class StudentFourthDecorator : BaseStudentDecorator
    {
        //表示父类的构造函数
        public StudentFourthDecorator(AbstractStudent student) : base(student) { }

        public override void Study()
        {
            base.Study();
            Console.WriteLine("装逼技巧四课程免费升级");
            //base.Notice();
        }
    }
}
