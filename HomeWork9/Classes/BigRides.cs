using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.Classes
{
    class BigRides
    {
        public int games;
        public List<Team> teams = new List<Team>();
        public Dictionary<string, IGames> tasks = new Dictionary<string, IGames>();
        public BigRides(int Games, List<Team> teams)
        {
            this.games = Games;
            this.teams = teams;
        }
        public void StartGames()
        {
            Dictionary<string, int> scores = new Dictionary<string, int>();
            scores.Add("Россия", 0);
            scores.Add("Франция", 0);
            scores.Add("Китай", 0);
            scores.Add("Украина", 0);
            for (int i = 0; i < games; i++)
            {
                foreach (Team j in teams)
                {
                    tasks.Add("Пляж", new BeachGame());
                    tasks.Add("Мышеловка", new MouseTrap());
                    tasks.Add("Море", new See());
                    tasks.Add("Рыбалка", new Fishing());
                    tasks.Add("Почтальоны", new Postman());
                    tasks.Add("Горка", new Slide());
                    tasks.Add("Моя Игра", new MyGame());
                    Console.WriteLine($"Начинается новое испытание для команды {j.team}\n Определите очерель испытания из списка ниже:");
                    foreach (string k in tasks.Keys)
                    {
                        Console.WriteLine(k);
                    }
                    for (int z = 0; z < 6; z++)
                    {
                        string tmp = Console.ReadLine();
                        while (!tasks.Keys.Contains(tmp))
                        {
                            Console.WriteLine("Игра выбрана не правильно, повторите попытку");
                            tmp = Console.ReadLine();
                        }
                        int count = tasks[tmp].ChooseGame(j);
                        Console.WriteLine($"Команда {j.team} получила {count} очков");
                        j.PlusScore(count);
                        tasks.Remove(tmp);
                        Console.Write($"Введите следующую игру для {j.team}\n");
                        Console.WriteLine("Список оставшихся игр");
                        foreach (string k in tasks.Keys)
                        {
                            Console.WriteLine(k);
                        }
                    }
                    tasks = new Dictionary<string, IGames>();
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Результаты " + (i + 1).ToString() + " набора испытаний");
                Console.ForegroundColor = ConsoleColor.White;
                int l = 1;
                foreach (Team team in teams.OrderByDescending(x => x.score))
                {
                    Console.WriteLine($"{l} место {team.team} c {team.score} очков");
                    l += 1;
                }
            }
        }
    }
}
