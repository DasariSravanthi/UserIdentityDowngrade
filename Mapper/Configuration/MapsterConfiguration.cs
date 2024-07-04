using Mapster;

using UserIdentity.Models.Entity;
using UserIdentity.Models.DTO;

public static class MapsterConfiguration
{
    public static void ConfigureMappings(TypeAdapterConfig config)
    {
      
      config.NewConfig<RegisterUserDto, User>();

    }
}