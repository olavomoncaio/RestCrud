using System.Text.Json.Serialization;

namespace AplicacoesDistribuidas.Model
{
    public class BaseResponse
    {
        [JsonIgnore]
        public int StatusCode { get; set; }

        public string Mensagem { get; set; }
    }
}
