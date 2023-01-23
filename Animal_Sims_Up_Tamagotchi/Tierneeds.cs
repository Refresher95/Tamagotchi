using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Sims_Up_Tamagotchi
{
    public abstract class Tierneeds
    {

        public String Type { get; set; }
        public double Hp_wert { get; set; }
        public double Hunger_wert { get; set; }


    public virtual void fuettern_plus()
        {
        }

        public virtual void fuettern_minus()
        { 
        }

        public virtual void kuscheln_plus() { }

        public virtual void kuscheln_minus() { }
    }
}
