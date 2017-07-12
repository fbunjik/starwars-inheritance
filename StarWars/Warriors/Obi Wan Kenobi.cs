using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Warriors
{
    class Obi_Wan_Kenobi : Jedi

    {
        public override string Name { get; } = "Obi Wan Kenobi";
        public override bool IsLightSide { get; } = true;
        public override bool IsForceUser { get; } = true;


               
        public Obi_Wan_Kenobi (int power) : base(power)
        {
        }


        public override void OnJoinBattle(BattleSimulator simulator)
        {
            
        }

        public override void PostCombatEffect(BattleSimulator simulator)
        {
            
        }

        public override void PreCombatEffect(BattleSimulator simulator)
        {
            foreach (var opponent in simulator.DarkSide.Warriors)
                if (!(opponent is Sith))
                    return;
            Power += 2;

            //string w [] = 
          
            //foreach (var w in )
            //{
            //    if (simulator.DarkSide.GetWarrior(simulator) is Sith)
            //{
            //        return;
            //}
            //    else
            //    {
                    
            //    }
            //}

           
        }
    }
}
