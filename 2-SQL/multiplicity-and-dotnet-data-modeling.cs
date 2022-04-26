class Restaurant
{
    private List<RestaurantType> Types;

    public void AddType(RestaurantType type)
    {
        if (Types.Count > 5)
            throw Ex
    }
}



class RestaurantType
{
    List<Restaurant> Restaurants;
}

static void Main()
{
    List<RestaurantType> types;
    List<Restaurant> allRestaurants;

    RestaurantType theType = ...;
    allRestaurants.Select(r => r.Types.Contains(theType))
}

// relationships between things have a "multiplicity"
// you need to know well what the multiplicity is before you start modelling.
// questions to ask are:
//    - each A could be connected to only one B? or several possible B?
//    - each B could be connected to only one A? or several possible A?
// - one to one
//     in C# : one class with all the data of both
            //   or, two classes, with one having a reference to the other
            //        or both referencing each other
    // in SQL: one table with all the data of both
    //       or, two tables, & 1 of them has a UNIQUE FOREIGN KEY to the other
// - one to many
    //  in C# : two classes, one with a property/field of the other
    //         and/or the other one with a collection property/field
    //    in SQL:  two tables, & 1 of them has (not UNIQUE) FOREIGN KEY to the other.
// - many to many
    // sql does not support many to many relationship...
    // but


// if table A has a foreign key to table B,
//   that means that each A can ONLY be connected to ONE B.

// ColorScheme
//     PrimaryColor
//     SecondaryColor
// Color
