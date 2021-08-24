using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo.Model
{
    public sealed class Singelton
    {
        private static object Singeltonlock = new object();
        private static Singelton SingleInstance = null;
        private static int Counter = 0;

        private Singelton()
        {
            Counter++;
            Console.WriteLine("Counter Value " + Counter.ToString());
        }
        public static Singelton GetInstance()
        {
            if (SingleInstance == null)
            {
                lock (Singeltonlock)
                {
                    if (SingleInstance == null)
                    {
                        SingleInstance = new Singelton();
                    }
                }
            }

            return SingleInstance;
        }


        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
        public void PrintInstanceCounter()
        {
            Console.WriteLine("Counter Value " + Counter.ToString());
        }
    }
}
