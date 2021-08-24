using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingletonDemo.Model;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Singelton singeltonAdmin = Singelton.GetInstance;
            singeltonAdmin.PrintDetails("Admin");
            Singelton singeltonUser = Singelton.GetInstance;
            singeltonUser.PrintDetails("User");
            Singelton singeltonSuperAdmin = Singelton.GetInstance;
            singeltonSuperAdmin.PrintDetails("Super Admin");
            Singelton singeltonHR = Singelton.GetInstance;
            singeltonHR.PrintDetails("HR");

            singeltonHR.PrintInstanceCounter();
            Console.ReadLine();
        }
    }
}
