using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// 1 适配器模式概述
    /// 2 类适配器模式和对象适配器模式
    /// 3 适配器模式的应用
    /// 
    /// 适配器：插座 电源适配器，做个转接的
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("*****************************");
                {
                    IHelper helper = new SqlserverHelper();
                    helper.Add<Program>();
                    helper.Delete<Program>();
                    helper.Update<Program>();
                    helper.Query<Program>();
                }
                Console.WriteLine("*****************************");
                {
                    IHelper helper = new MysqlHelper();
                    helper.Add<Program>();
                    helper.Delete<Program>();
                    helper.Update<Program>();
                    helper.Query<Program>();
                }
                Console.WriteLine("*****************************");
                {
                    IHelper helper = new OracleHelper();
                    helper.Add<Program>();
                    helper.Delete<Program>();
                    helper.Update<Program>();
                    helper.Query<Program>();
                }
                //程序已经确定好规范IHelper,
                //新增了一个RedisHelper--第三方的
                //二者规范不一致，就是没有实现接口
                //Console.WriteLine("*****************************");
                //{
                //    IHelper helper = new RedisHelper();
                //    helper.Add<Program>();
                //    helper.Delete<Program>();
                //    helper.Update<Program>();
                //    helper.Query<Program>();
                //}

                //继承 既满足现有的规范调用，又没有修改RedisHelper  
                //类适配器模式
                Console.WriteLine("*****************************");
                {
                    IHelper helper = new RedisHelperInherit();
                    helper.Add<Program>();
                    helper.Delete<Program>();
                    helper.Update<Program>();
                    helper.Query<Program>();
                }
                //组合 既满足现有的规范调用，又没有修改RedisHelper 
                //对象适配器
                Console.WriteLine("*****************************");
                {
                    IHelper helper = new RedisHelperObject();
                    helper.Add<Program>();
                    helper.Delete<Program>();
                    helper.Update<Program>();
                    helper.Query<Program>();
                }
                //组合优于继承？
                //二者都会先构造一个RedisHelper，但是继承是强侵入，父类的东西子类必须有
                //灵活性，继承只为一个类服务；组合可以面向抽象为多个类型服务
                {
                    RedisHelperInherit redisHelperInherit = new RedisHelperInherit();
                    redisHelperInherit.DeleteRedis<Program>();
                }
                {
                    RedisHelperObject redisHelperObject = new RedisHelperObject();
                    redisHelperObject.Add<Program>();
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
