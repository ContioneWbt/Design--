﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{

    /// <summary>
    /// 父类是BaseStudentDecorator，爷爷类AbstractStudent
    /// </summary>
    public class StudentRegDecorator : BaseStudentDecorator
    {
        //表示父类的构造函数
        public StudentRegDecorator(AbstractStudent student) : base(student) { }

        public override void Study()
        {
            Console.WriteLine("注册");

            base.Study();
        }
    }
}
