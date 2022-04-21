using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonModels
{
    public class Ability
    {
        public string Name { get; set; }
        private int _PP;
        public int PP
        {
            get => _PP;
            set
            {
                if (value > 0)
                    _PP = value;
                else
                    throw new Exception("You cannot set PP lowwr that 0!");
            }
        }
        public int Power { get; set; }
        public int Accuracy { get; set; }

        public Ability()
        {
            Name = "Tackle";
            PP = 40;
            Power = 40;
            Accuracy = 80;
        }
    }
}
