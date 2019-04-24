using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class RedisHelperObject : IHelper
    {
        public RedisHelperObject()
        {
            Console.WriteLine($"构造{this.GetType().Name}");
        }

        private RedisHelper _RedisHelper = new RedisHelper();//属性注入  声明写死      一定有
        public RedisHelperObject(RedisHelper redisHelper)//构造函数 可以替换(需要抽象)  一定有(不考虑其他构造函数)
        {
            this._RedisHelper = redisHelper;
        }

        public void SetObject(RedisHelper redisHelper)//方法注入 可以替换(需要抽象)  不一定有
        {
            this._RedisHelper = redisHelper;
        }

        public void Add<T>()
        {
            this._RedisHelper.AddRedis<T>();
        }

        public void Delete<T>()
        {
            this._RedisHelper.DeleteRedis<T>();
        }

        public void Query<T>()
        {
            this._RedisHelper.QueryRedis<T>();
        }

        public void Update<T>()
        {
            this._RedisHelper.UpdateRedis<T>();
        }
    }
}
