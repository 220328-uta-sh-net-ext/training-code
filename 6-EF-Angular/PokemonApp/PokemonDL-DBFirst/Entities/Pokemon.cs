using System;
using System.Collections.Generic;

namespace PokemonDL_DBFirst.Entities
{
    public partial class Pokemon
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public bool? Active { get; set; }
    }
}
