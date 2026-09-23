using System;
using System.Collections.Generic;
using System.Text;

namespace Okoszisztema
{
    internal class Fox : Field, IEntity
    {
        int energy_level_;
        public Fox(int energy_level_) { 
            this.energy_level_ = energy_level_;
        }
        //false - nem halt meg, true - meghalt
        public bool Step(ref List<List<Field>> map) {
            --energy_level_;
            if (energy_level_ == 0) {
                return true;
            }
            return false;
        }

        public void Mate(int cost) {
            if (energy_level_ - cost > 0)
            {
                energy_level_ -= cost;
            }
        }

        public void Eat(int amoumt) { 
            energy_level_+= amoumt;
        }
    }
}
