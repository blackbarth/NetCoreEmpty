
using Microsoft.Extensions.Configuration;

namespace NetCoreEmpty.Sevices
{
    public class ConfigurationMensagemService : IMensagemService
    {
        private IConfiguration _config;

        public ConfigurationMensagemService(IConfiguration config)
        {
            _config = config;
        }
        public string GetMensagem()
        {
            return _config["Mensagem"];
        }
    }
}
