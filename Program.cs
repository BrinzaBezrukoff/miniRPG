﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace RPG
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ILogger logger = new LoggerConsole();
            Team[] teams = { new Team("Red", ref logger), new Team("Green", ref logger) };

            foreach (Team team in teams)
            {
                team.ChooseHeroes();
                Console.Clear();
            }

            int now_turn = 0;
            
            while (!teams[0].IsLose && !teams[1].IsLose)
            {
                int next_turn = (now_turn + 1) % 2;
                teams[now_turn].Turn(teams[next_turn]);
                now_turn = next_turn;
            }

            Console.Read();
        }
    }
}
