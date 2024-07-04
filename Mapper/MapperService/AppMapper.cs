using Mapster;

namespace UserIdentity.Mapper.MapperService;

public class AppMapper
{
    private readonly TypeAdapterConfig _config;

    public AppMapper(TypeAdapterConfig config)
    {
        _config = config;
    }

    public TDestination Map<TSource, TDestination>(TSource source)
    {
        return source.Adapt<TSource, TDestination>(_config);
    }

    public void Map<TSource, TDestination>(TSource source, TDestination destination)
    {
        source.Adapt(destination, _config);
    }
}