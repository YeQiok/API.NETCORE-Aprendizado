using Newtonsoft.Json;

namespace API.NETCORE
{
    class CEPResponse
    {
        [JsonProperty("cep")]
        public string Cep { get; set; }
        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }
        [JsonProperty("complemento")]
        public string Complemento { get; set; }
        [JsonProperty("bairro")]        public string Bairro { get; set; }        [JsonProperty("localidade")]        public string Localidade { get; set; }        [JsonProperty("uf")]        public string UF { get; set; }        [JsonProperty("ibge")]        public string IBGE { get; set; }        [JsonProperty("gia")]        public string Gia { get; set; }        [JsonProperty("ddd")]        public string DDD { get; set; }    }
}
