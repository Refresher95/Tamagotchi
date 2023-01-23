using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Sims_Up_Tamagotchi
{
    internal abstract class Tierneeds
    {

        internal String Type { get; set; }
        internal double Hp_wert { get; set; }
        internal double Hunger_wert { get; set; }


        public virtual void fuettern_plus()
        {

        }

        public virtual void fuettern_minus()
        {

        }

        public virtual void kuscheln_plus() 
        {

        }

        public virtual void kuscheln_minus() 
        {

        }
    }
}
