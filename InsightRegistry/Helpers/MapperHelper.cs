using AutoMapper;

namespace InsightRegistry.Helpers
{
    public class MapperHelper
    {
        internal static T Map<T, U>(T destination, U source) where T : class where U : class
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<U, T>());

            var mapper = config.CreateMapper();

            var returnModel = mapper.Map<U, T>(source);

            return returnModel;
        }
    }
}
