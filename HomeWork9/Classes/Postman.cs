﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.Classes
{
   
        class Postman : IGames
        {
            public int ChooseGame(Team team)
            {
                Console.WriteLine(team.team + " играет в почтальона");
                Random random = new Random();
                int value = random.Next(0, 10);
                return value;
            }
        }
    
}
