using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo.Model
{
    public  sealed class Singelton
    {
        private static object Singeltonlock = new object();
        private static Singelton Instance = null;
        private static int Counter = 0;
        public static Singelton GetInstance
        {

            get
            {
                lock (Singeltonlock)
                {
                    if (Instance == null)
                    {
                        Instance = new Singelton();
                    }
                }
                return Instance;

            }
        }

        private Singelton()
        {
            Counter++;
            Console.WriteLine("Counter Value " + Counter.ToString());
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
