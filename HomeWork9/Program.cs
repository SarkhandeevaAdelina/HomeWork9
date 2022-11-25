using HomeWork9.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    internal class Program
    {
        static bool StartDialog()
        {
            Console.WriteLine("Добрый день. Введите свою фамилию и имя, чтобы начать работу в программе");
            string tmp = Console.ReadLine();
            while (tmp != "Оливье Ганьян")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("У вас нет прав доступа для работы с данной программой! Повторите попытку");
                Console.ForegroundColor = ConsoleColor.White;
                tmp = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Добро пожаловать Оливье!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Сегодня в играх примут участие следующие команды:\nРоссия\nФранция\nКитай\nУкраина");
            Console.WriteLine("Хотите сформировать список игр на сегодняшний день?");
            tmp = Console.ReadLine();
            if (tmp == "да") 
            { 
                return true; 
            }
            else 
            { 
                return false; 
            }
        }
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            teams.Add(new Team("Россия"));
            teams.Add(new Team("Франция"));
            teams.Add(new Team("Китай"));
            teams.Add(new Team("Украина"));
            int cl = 1;
            foreach (Team i in teams)
            {
                i.AddInTeam("Участники команд" + cl.ToString() + ".txt");
                cl += 1;
            }
            BigRides bigRides = new BigRides(1, teams);
            if (StartDialog())
            {
                bigRides.StartGames();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Хорошего дня, сеньор Оливье.");
            }
        }
    }
}
