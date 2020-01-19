using System;

namespace Systemy_kontroli
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginUser();
        }
        static void LoginUser(){
            Console.WriteLine("Podaj login");
            Console.ReadLine();
            Console.WriteLine("Podaj hasło");

            // if!(ligin in logins or password in passwords){
            //     "Niepoprawny login lub hasło"
            // }

        }
    }
}
