using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppRpgEtec.Models;

namespace AppRpgEtec.Services.Enderecos
{
    public class EnderecoService
    {
        private readonly Request _request;
        private const string apiUrlBase = "https://nominatim.openstreetmap.org/search?format=json&q=";
        public async Task<Endereco> GetEnderecoAsync(string cep)
        {
            string urlComplementar = string.Format("{lat}","{lon}");
            var personagem = await _request.GetAsync<Models.Endereco>(apiUrlBase+urlComplementar, string.Empty);
            return personagem;
        }
    }
}
