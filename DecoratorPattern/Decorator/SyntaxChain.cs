using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
  public static  class SyntaxChain
    {
        public static AbstractStudent First(this AbstractStudent student)
        {
            return new StudentFirstDecorator(student);
        }
        public static AbstractStudent Second(this AbstractStudent student)
        {
            return  new StudentSecondDecorator(student);
        }
        public static AbstractStudent Third(this AbstractStudent student)
        {
            return new StudentThirdDecorator(student);
        }
        public static AbstractStudent Fourth(this AbstractStudent student)
        {
            return new StudentFourthDecorator(student);
        }
        public static AbstractStudent Notices(this AbstractStudent student)
        {
            return new StudentNotices(student);
        }
        
    }
}
