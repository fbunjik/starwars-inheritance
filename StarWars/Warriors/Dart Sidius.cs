using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Warriors
{
    class Dart_Sidius : Sith
    {

            public override string Name { get; } = "Dart Sidius";
            public override bool IsLightSide { get; } = false;

            public Dart_Sidius(int power) : base(power)
            {
            }


        public override void OnLeaveBattle(BattleSimulator simulator)
        {
            
        }

        public override void PostCombatEffect(BattleSimulator simulator)
        {
            
        }

        public override void PreCombatEffect(BattleSimulator simulator)
        {
            foreach (var w in simulator.LightSide.Warriors)

                
                if (w is Jedi)
                {
                    {
                        simulator.LightSide.Morale -= 1;
                        Console.WriteLine("Az ellenfél morálját minden ellenséges Jedi után 1 ponttal csökkenti.");
                    }
                }

        }
    }
}
