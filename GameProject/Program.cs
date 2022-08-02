using GameProject.Abstract.Interface;
using GameProject.Adapters;
using GameProject.Entities;
using System;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string karsilamaMetni =
                "================================================\n" +
                "OYUN MERKEZİNE HOŞGELDİNİZ.\n";
            Console.WriteLine(karsilamaMetni);
            Console.ReadLine();
            IUserControlService test = new MernisControlManager();
            var deneme = test.CheckRealPerson(new User
            {
                Id = 1,
                IdentityNumber = 35200687034,
                Name = "BURAK CAN",
                Surname = "YURDACAN",
                BirthDate = Convert.ToDateTime("09.08.1993")
            });
            Console.WriteLine(deneme.ToString());
        }
    }
}
