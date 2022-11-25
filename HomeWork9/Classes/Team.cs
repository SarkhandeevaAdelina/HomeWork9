using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork9.Classes
{
    class Team
    {
        public string team;
        public int score;
        public List<string> members = new List<string>();
        public Team(string team)
        {
            this.team = team;
        }
        public void AddInTeam(string path)
        {
            StreamReader f = new StreamReader(path);
            while (!f.EndOfStream)
            {
                if (members.Count < 15)
                {
                    string s = f.ReadLine();
                    members.Add(s);
                }
                else
                {
                    Console.WriteLine($"Игрок {f.ReadLine()} отправлен на скамью запасных");
                }
            }
            f.Close();
            if (members.Count != 15)
            {
                Console.WriteLine("Недостаточне количество игроков, пожалуйста проверьте файлы участников");
                System.Threading.Thread.Sleep(5000);
                Environment.Exit(0);
            }
        }
        public void PrintTeam()
        {
            Console.WriteLine(team);
            Console.WriteLine("Участники команды");
            foreach (string i in members)
            {
                Console.WriteLine(i);
            }
        }
        public void PlusScore(int sc)
        {
            score += sc;
        }
    }
}
