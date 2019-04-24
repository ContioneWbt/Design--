using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class RedisHelperInherit : RedisHelper, IHelper
    {
        public RedisHelperInherit()
        {
            Console.WriteLine($"构造{this.GetType().Name}");
        }

        public void Add<T>()
        {
            base.AddRedis<T>();
        }

        public void Delete<T>()
        {
            base.DeleteRedis<T>();
        }

        public void Query<T>()
        {
            base.QueryRedis<T>();
        }

        public void Update<T>()
        {
            base.UpdateRedis<T>();
        }
    }
}
