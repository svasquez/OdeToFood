using Microsoft.Extensions.Configuration;

namespace OdeToFood
{
    public interface ISaludo
    {
        string GetMessageOfDay();
    }

    public class Saludo : ISaludo
    {
        private readonly IConfiguration _configuration;

        public Saludo(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetMessageOfDay() => _configuration["Saludos"];
    }
}