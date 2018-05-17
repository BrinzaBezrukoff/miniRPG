﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace RPG
{
    public class Defender : Hero
    {
        public Defender(Team team) : base(team, 100, 8, 0.25, "Defender")
        {

        }

        public override string ToString()
        {
            return $"1.Can attack({Damage} damage)\n2.Can protect friends(-25% damage)\n3.Can heal himself(+25% HP)\nIn passive use shield(-{Protection * 100}% damage)";
        }

        public override void Turn(Team other)
        {
            int action = logger.Parse(1, 3, "Choose action: ");
            switch (action)
            {
                case 1:
                    Attack(other);
                    break;
                case 2:
                    ProtectOther(HisTeam);
                    break;
                case 3:
                    Healing();
                    break;
            }
        }

        private void ProtectOther(Team our)
        {
            int ourHeroesCount = our.ShowTeamHeroes();
            int target = logger.Parse(1,ourHeroesCount, "Choose target: ") - 1;
            our.Heroes[target].Protection = 0.25;
        }
    }
}
