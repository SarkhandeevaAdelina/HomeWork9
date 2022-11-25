using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.Classes
{
    class Fishing : IGames
    {
        public int ChooseGame(Team team)
        {
            Console.WriteLine(team.team + " играет в рыбалку");
            Random random = new Random();
            int value = random.Next(0, 10);
            return value;
        }
    }
}
