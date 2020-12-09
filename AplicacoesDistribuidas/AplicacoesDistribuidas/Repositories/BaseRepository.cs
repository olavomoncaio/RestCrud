using Microsoft.Extensions.Configuration;

namespace AplicacoesDistribuidas.Repositories
{
    public class BaseRepository
    {
        private readonly IConfiguration _configuration;

        public BaseRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected string ObterConexao
        {
            get { return _configuration.GetConnectionString("PoliscrumBase"); }
        }
    }
}
