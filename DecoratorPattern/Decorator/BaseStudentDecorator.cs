using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DecoratorPattern.Decorator
{
    /// <summary>
    /// 继承+组合
    /// 装饰器的基类
    /// 也是一个学员，继承了抽象类
    /// </summary>
    public class BaseStudentDecorator : AbstractStudent
    {
        private AbstractStudent _Student = null;//用了组合加override
        public BaseStudentDecorator(AbstractStudent student)
        {
            this.Id = student?.Id;
            this.Name = student?.Name;
            this._Student = student;
        }

        public override void Study()
        {
            this._Student.Study();
            //Console.WriteLine("******************************");
            //基类装饰器必须是个空的行为  会重复
        }

        /// <summary>
        /// 当前方法额外的操作
        /// </summary>
        public void Notice()
        {
            MethodInfo[] methods = this.GetType().GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var item in methods)
            {
                NoticeAttribute attr = (NoticeAttribute)Attribute.GetCustomAttribute(item, typeof(NoticeAttribute));
                if (attr == null || attr.SubjectID == null) { continue; }

                if (attr.SubjectID.Count(o => o == _Student.Id) == 1)
                {
                    try
                    {
                        // 调用方法
                        item.Invoke(this, new object[] { "param" });
                    }
                    catch
                    {
                    }
                }
            }
        }
    }
}
