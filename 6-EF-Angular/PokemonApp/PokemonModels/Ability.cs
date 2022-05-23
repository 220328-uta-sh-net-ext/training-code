using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonModels;

[Table("ability")]
public class Ability
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }

    int? _PP;
    public int? PP
    {
        get => _PP;
        set
        {
            if (value > 0)
                _PP = value;
            else
                throw new Exception("You cannot set PP lower that 0!");
        }
    }

    public int? Power { get; set; }
    public int? Accuracy { get; set; }
    //[ForeignKey("Id")]
    public int PokemonId { get; set; }//Foreign Key to table Pokemon
    public Ability()
    {
        Name = "Tackle";
        PP = 40;
        Power = 40;
        Accuracy = 80;
    }
}
