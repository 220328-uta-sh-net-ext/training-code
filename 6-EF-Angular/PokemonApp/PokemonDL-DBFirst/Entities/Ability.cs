using System;
using System.Collections.Generic;

namespace PokemonDL_DBFirst.Entities
{
    public partial class Ability
    {
        public string Name { get; set; }
        public int? Pp { get; set; }
        public int? Power { get; set; }
        public int? Accuracy { get; set; }
    }
}
