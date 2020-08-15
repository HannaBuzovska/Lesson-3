using Nancy;

namespace WebApi
{
    public class HelloModule: NancyModule
    {
        public HelloModule()
        {
            Get("/nancy-api/{name}", parameters =>
            {
                return string.Concat("Hello ", parameters.Name);
            });
        }

    }
}