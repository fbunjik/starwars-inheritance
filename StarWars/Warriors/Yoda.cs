using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Warriors
{
    class Yoda : Jedi
    {
        public override string Name { get; } = "Yoda";
        public override bool IsLightSide { get; } = true;

        public Yoda(int power) : base(power)
        {
        }

        public override void DecreasePower(BattleSimulator simulator, int power)
        {
            if(simulator.Chance(10))
            Power -= power / 2;
            Power -= power;
        }
        public override void PostCombatEffect(BattleSimulator simulator)
        {

        }
        public override void OnLeaveBattle(BattleSimulator simulator)
        {

        }

        public override void OnJoinBattle(BattleSimulator simulator)
        {

        }

        public override void PreCombatEffect(BattleSimulator simulator)
        {

        }
    }
}
