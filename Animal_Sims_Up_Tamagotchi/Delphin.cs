using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Sims_Up_Tamagotchi
{
    class Delphin : Tierneeds
    {
        public Delphin()
        {
            Type = "Delfin";
            Hp_wert = 100;
            Hunger_wert = 100;
        }

        public override void fuettern_minus()
        {
            Hunger_wert -= 2;
        }

        public override void fuettern_plus()
        {
            Hunger_wert += 20;
        }

        public override void kuscheln_plus()
        {
            Hp_wert += 20;
        }

        public override void kuscheln_minus()
        {
            Hp_wert -= 1;
        }


    }
}

