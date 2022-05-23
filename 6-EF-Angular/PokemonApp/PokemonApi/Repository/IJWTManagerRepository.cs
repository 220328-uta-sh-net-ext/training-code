using PokemonModels;

namespace PokemonApi.Repository
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(User user);
    }
}
