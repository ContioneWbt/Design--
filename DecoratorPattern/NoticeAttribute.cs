using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// 通知业务部门 特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class NoticeAttribute : Attribute
    {
        private int[] subjectID;

        /// <summary>
        /// 流程处理科目
        /// </summary>
        public int[] SubjectID
        {
            get { return subjectID; }
            set { subjectID = value; }
        }

        public NoticeAttribute(params int[] subjectID)
        {
            this.subjectID = subjectID;
        }

       
    }
   
}
