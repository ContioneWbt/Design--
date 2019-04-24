using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{

    /// <summary>
    /// 父类是BaseStudentDecorator，爷爷类AbstractStudent
    /// </summary>
    public class StudentNotices : BaseStudentDecorator
    {
        public StudentNotices(AbstractStudent student)
            : base(student)//表示父类的构造函数
        {
          
        }

        public override void Study()
        {
            base.Study();
            //执行Notice
            base.Notice();
        }

        [Notice(20)]
        private void Notice1()
        {
            Console.WriteLine("中级大招！");
        }
    }
}
