using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TonglBin.DataTools;
using TonglBin.Model;

namespace TonglBin.UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 
            ////Insert 
            //List<Users> users = new List<Users>();
            //Users user1 = new Users();
            //user1.UserName = "ZZB1";
            //user1.Email = "abcde@qq.com";
            //user1.Address = "北京";
            //Users user2 = new Users();
            //user2.UserName = "ZZB2";
            //user2.Email = "abcde@qq.com";
            //user2.Address = "北京";
            //users.Add(user1);users.Add(user2);
            //string sql = "Insert into Users values (@UserName, @Email, @Address)";
            //DapperDataHelp<Users>.Execute(sql, user);

            ////Query
            //Users user = new Users();
            //user.UserName = "ZZB";
            //string sql = "select * from Users where UserName=@UserName";
            //DapperDataHelp<Users> dapperHelp = DapperDataHelp<Users>.GetDapperInstance();
            //List<Users> users = dapperHelp.Query(sql, user);

            ////Update
            //Users user = new Users();
            //user.UserId = 9;
            //user.UserName = "TongXuejie";
            //string sql = "update Users set UserName=@UserName where UserID=@UserID";
            //DapperDataHelp<Users> dapperHelp = DapperDataHelp<Users>.GetDapperInstance();
            //Int32 cnt = dapperHelp.Execute(sql, user);

            ////Delete
            //Users user = new Users();
            //user.UserId = 9;
            //string sql = "delete Users where UserID=@UserID";
            //DapperDataHelp<Users> dapperHelp = DapperDataHelp<Users>.GetDapperInstance();
            //Int32 cnt = dapperHelp.Execute(sql, user);
            #endregion

            //RedisTest();

            string redisHost = ConfigurationManager.AppSettings["TonglBinRedisConn"];
            int redisPort = Int32.Parse(ConfigurationManager.AppSettings["TonglBinRedisPort"]);
        }

        static void RedisTest()
        {
            //在Redis中存储常用的5种数据类型：String,Hash,List,SetSorted set
            //var client = new RedisClient("127.0.0.1", 6379);
            var client = new RedisClient("192.168.1.109", 6379);

            AddString(client);
            //AddHash(client);
            //AddList(client);
            //AddSet(client);
            //AddSetSorted(client);

            Console.ReadLine();
        }

        private static void AddString(RedisClient client)
        {
            var timeOut = new TimeSpan(0, 0, 0, 30);
            client.Add("Test", "Learninghard", timeOut);
            while (true)
            {
                if (client.ContainsKey("Test"))
                {
                    Console.WriteLine("String Key: Test -Value: {0}, 当前时间: {1}", client.Get<string>("Test"), DateTime.Now);
                    Thread.Sleep(10000);
                }
                else
                {
                    Console.WriteLine("Value 已经过期了，当前时间：{0}", DateTime.Now);
                    break;
                }
            }

            var person = new Person() { Name = "Learninghard", Age = 26 };
            client.Add("lh", person);
            var cachePerson = client.Get<Person>("lh");
            Console.WriteLine("Person's Name is : {0}, Age: {1}", cachePerson.Name, cachePerson.Age);
        }

        private static void AddHash(RedisClient client)
        {
            if (client == null) throw new ArgumentNullException("client");

            client.SetEntryInHash("HashId", "Name", "Learninghard");
            client.SetEntryInHash("HashId", "Age", "26");
            client.SetEntryInHash("HashId", "Sex", "男");

            var hashKeys = client.GetHashKeys("HashId");
            foreach (var key in hashKeys)
            {
                Console.WriteLine("HashId--Key:{0}", key);
            }

            var haskValues = client.GetHashValues("HashId");
            foreach (var value in haskValues)
            {
                Console.WriteLine("HashId--Value:{0}", value);
            }

            var allKeys = client.GetAllKeys(); //获取所有的key。
            foreach (var key in allKeys)
            {
                Console.WriteLine("AllKey--Key:{0}", key);
            }
        }

        private static void AddList(RedisClient client)
        {
            if (client == null) throw new ArgumentNullException("client");

            client.EnqueueItemOnList("QueueListId", "1.Learnghard");  //入队
            client.EnqueueItemOnList("QueueListId", "2.张三");
            client.EnqueueItemOnList("QueueListId", "3.李四");
            client.EnqueueItemOnList("QueueListId", "4.王五");
            var queueCount = client.GetListCount("QueueListId");

            for (var i = 0; i < queueCount; i++)
            {
                Console.WriteLine("QueueListId出队值：{0}", client.DequeueItemFromList("QueueListId"));   //出队(队列先进先出)
            }

            client.PushItemToList("StackListId", "1.Learninghard");  //入栈
            client.PushItemToList("StackListId", "2.张三");
            client.PushItemToList("StackListId", "3.李四");
            client.PushItemToList("StackListId", "4.王五");

            var stackCount = client.GetListCount("StackListId");
            for (var i = 0; i < stackCount; i++)
            {
                Console.WriteLine("StackListId出栈值：{0}", client.PopItemFromList("StackListId"));   //出栈(栈先进后出)
            }
        }

        //它是string类型的无序集合。set是通过hash table实现的，添加，删除和查找,对集合我们可以取并集，交集，差集
        private static void AddSet(RedisClient client)
        {
            if (client == null) throw new ArgumentNullException("client");

            client.AddItemToSet("Set1001", "A");
            client.AddItemToSet("Set1001", "B");
            client.AddItemToSet("Set1001", "C");
            client.AddItemToSet("Set1001", "D");
            var hastset1 = client.GetAllItemsFromSet("Set1001");
            foreach (var item in hastset1)
            {
                Console.WriteLine("Set无序集合Value:{0}", item); //出来的结果是无须的
            }

            client.AddItemToSet("Set1002", "K");
            client.AddItemToSet("Set1002", "C");
            client.AddItemToSet("Set1002", "A");
            client.AddItemToSet("Set1002", "J");
            var hastset2 = client.GetAllItemsFromSet("Set1002");
            foreach (var item in hastset2)
            {
                Console.WriteLine("Set无序集合ValueB:{0}", item); //出来的结果是无须的
            }

            var hashUnion = client.GetUnionFromSets(new string[] { "Set1001", "Set1002" });
            foreach (var item in hashUnion)
            {
                Console.WriteLine("求Set1001和Set1002的并集:{0}", item); //并集
            }

            var hashG = client.GetIntersectFromSets(new string[] { "Set1001", "Set1002" });
            foreach (var item in hashG)
            {
                Console.WriteLine("求Set1001和Set1002的交集:{0}", item);  //交集
            }

            var hashD = client.GetDifferencesFromSet("Set1001", new string[] { "Set1002" });  //[返回存在于第一个集合，但是不存在于其他集合的数据。差集]
            foreach (var item in hashD)
            {
                Console.WriteLine("求Set1001和Set1002的差集:{0}", item);  //差集
            }

        }

        /*
        sorted set 是set的一个升级版本，它在set的基础上增加了一个顺序的属性，这一属性在添加修改.元素的时候可以指定，
        * 每次指定后，zset(表示有序集合)会自动重新按新的值调整顺序。可以理解为有列的表，一列存 value,一列存顺序。操作中key理解为zset的名字.
        */
        private static void AddSetSorted(RedisClient client)
        {
            if (client == null) throw new ArgumentNullException("client");

            client.AddItemToSortedSet("SetSorted1001", "A");
            client.AddItemToSortedSet("SetSorted1001", "B");
            client.AddItemToSortedSet("SetSorted1001", "C");
            var listSetSorted = client.GetAllItemsFromSortedSet("SetSorted1001");
            foreach (var item in listSetSorted)
            {
                Console.WriteLine("SetSorted有序集合{0}", item);
            }

            client.AddItemToSortedSet("SetSorted1002", "A", 400);
            client.AddItemToSortedSet("SetSorted1002", "D", 200);
            client.AddItemToSortedSet("SetSorted1002", "B", 300);

            // 升序获取第一个值:"D"
            var list = client.GetRangeFromSortedSet("SetSorted1002", 0, 0);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //降序获取第一个值:"A"
            list = client.GetRangeFromSortedSetDesc("SetSorted1002", 0, 0);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
