namespace PokemonModels;

public class Pokemon
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int Health { get; set; }

    //public int AbilityCount => _abilities.Count;
    //private List<string> _abilities;
    //public List<string> Abilities
    //{
    //    get => _abilities;

    //    //cannot set abilities to have more than 4
    //    set
    //    {
    //        if (value.Count <= 4)
    //            _abilities = value;
    //        else
    //            throw new Exception("Pokemon cannot hold more than 4 abilities");
    //    }
    //}

    //Abilities -> Name, Power, Accuracy
    List<Ability> _abilities;
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
        Name = "?";
        Level = 0;
        Attack = 0;
        Defense = 0;
        Health = 0;
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
