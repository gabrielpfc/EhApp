using System;
using System.Net.Http;
using System.Text;
using EhApp.Model;
using Newtonsoft.Json;

namespace UsuarioFull.Layers.Service
{
    public class UsuarioFullService
    {

        public EhApp.Model.UsuarioFullModel Get(int _id)
        {
            var uri = String.Format("http://fiapcoin-webapi.azurewebsites.net/api/Investidor/{0}", _id);

            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.GetAsync(uri).Result;

            if (resposta.IsSuccessStatusCode)
            {
                var resultado = resposta.Content.ReadAsStringAsync().Result;
                var usuarioFull = JsonConvert.DeserializeObject<UsuarioFullModel>(resultado);
                usuarioFull.IdUsuarioFull = usuarioFull.TreinoUsuarioFull.IdCartilha;
                return usuarioFull;
            }
            else
            {
                throw new Exception("Dados do usuário não encontrado!");
            }
        }



        public void Save(UsuarioFullModel _usuarioFull)
        {

            var uri = String.Format("http://fiapcoin-webapi.azurewebsites.net/api/Investidor/{0}", _usuarioFull.IdUsuarioFull);

            var conteudoJson = Newtonsoft.Json.JsonConvert.SerializeObject(_usuarioFull);
            var conteudoJsonString = new StringContent(conteudoJson, Encoding.UTF8, "application/json");

            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.PutAsync(uri, conteudoJsonString).Result;

            if (!resposta.IsSuccessStatusCode)
            {
                throw new Exception("Dados do investidor não encontrado!");
            }

        }


    }
}
