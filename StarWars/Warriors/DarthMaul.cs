using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Warriors
{
    class DarthMaul : Sith
    {
        public override string Name { get; } = "Darth Maul";
        public override bool IsLightSide { get; } = false;
        public DarthMaul(int power) : base(power)
        { }

        public override void OnJoinBattle(BattleSimulator simulator)
        {          
            simulator.LightSide.Morale -= 3;
            Console.WriteLine("Az ellenfél morálja -3 ponttal csökkent");
        }

        public override void OnLeaveBattle(BattleSimulator simulator)
        {
        }

        public override void PostCombatEffect(BattleSimulator simulator)
        {
        }

        public override void PreCombatEffect(BattleSimulator simulator)
        {
        }
    }
}
