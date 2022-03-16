using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TasksNetFramework
{
    class Program
    {
        static async Task<int> GetTopologyFromGateway()
        {
            Console.WriteLine("Gateway method begin");
            var res = await Task.Run(() =>
            {
                Thread.Sleep(8000);
                return 12345;
            });
            Console.WriteLine("Gateway method end");
            return res;
        }

        static async Task<int> GetMonitoringTopology()
        {
            return await GetTopologyFromGateway();
        }

        public struct MyStruct
        {
            public int Counter { get; set; }
            public void Inc() => Counter++;
        }

        static void Main(string[] args)
        {
            var str = new MyStruct();
            //str.Counter = 100;

            var test = new List<MyStruct> { str };
            var derf = test.First();
            derf.Inc();
            derf.Inc();
            Console.WriteLine(derf.Counter);
            //var derf = test[0];
            //derf.Inc();
            //derf.Inc();
            //derf.Inc();
            //Console.WriteLine(derf.Counter);

            var list = new List<int>(){0};
            list[0]++;
            list[0]++;
            list[0]++;

            //var res = GetMonitoringTopology();

            //Console.WriteLine("Main program");

            //res.Wait();
            //int num = res.Result;

            //Console.WriteLine("End of program");
            //Console.Read();
        }
    }
}
