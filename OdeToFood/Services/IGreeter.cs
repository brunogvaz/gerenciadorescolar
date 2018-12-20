using Microsoft.Extensions.Configuration;

namespace GerenciadorEscolar.Services
{
    public interface IGreeter
    {
        string GetMessageofDay();
    }
    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetMessageofDay()
        {
            return _configuration["Greeting"];
        }
    }

}