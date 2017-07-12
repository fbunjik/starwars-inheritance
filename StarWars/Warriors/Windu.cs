using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Warriors
{
    class Mace_Windu : Jedi
    {
        public Mace_Windu(int power) : base(power)
        {
        }

        public override string Name { get; } = "Mace_Windu";
        public override bool IsLightSide { get; } = true;
        public override bool IsForceUser { get; } = true;

        public override void OnJoinBattle(BattleSimulator simulator)
        {
            
        }

        public override void PostCombatEffect(BattleSimulator simulator)
        {
            
        }

        public override void PreCombatEffect(BattleSimulator simulator)
        {
            
        }
        public override void OnLeaveBattle(BattleSimulator simulator)
        {

            if ((Power <= 0) && (simulator.DarkSide.GetWarrior(simulator).Power > 0))
                simulator.DarkSide.GetWarrior(simulator).DecreasePower(simulator, 1);

        }
    }
}
