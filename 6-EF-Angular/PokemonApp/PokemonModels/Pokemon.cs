using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace PokemonModels;

[Table("pokemon")]
public class Pokemon// table name
{
    [Key]//Primary key of the table
    [Column("id")]
    public int Id { get; set; }
    private string name;
    [Required]
    public string Name {
        get { return name; }
        set {
            if (Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                name = value;
            else
                throw new ValidationException("Pokemon name ony contains letters");
        } 
    }
    [Range(1,100)]
    public int? Level { get; set; }
    public int? Attack { get; set; }
    public int? Defense { get; set; }
    public int? Health { get; set; }
    //[Range(2,100)]
    //public string Type { get; set; }

    List<Ability> _abilities;//navigation property
    public List<Ability> Abilities
    {
        get => _abilities;

        //cannot set abilities to have more than 4
        set
        {
            if (value.Count <= 4)
                _abilities = value;
            else
                throw new Exception("Pokemon cannot hold more than 4 abilities");
        }
    }

    //Default constructor to add default values to the properties
    public Pokemon()
    {
        _abilities = new List<Ability>()
        {
            new Ability()
        };
    }
    public override string ToString()
    {
        string result = $"Name: {Name}\nLevel: {Level}\nAttack: {Attack}\nDefense: {Defense}\nHealth: {Health}";
        if (Abilities is not null && Abilities.Count > 0)
        {
            result += "\nAbilities: " + string.Join(", ", Abilities.Select(a => a.Name));
        }
        return result;
    }
}
