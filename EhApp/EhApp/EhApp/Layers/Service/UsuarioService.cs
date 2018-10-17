using System;
using System.Net.Http;
using System.Text;
using EhApp.Model;
using Newtonsoft.Json;

namespace EhApp.Layers.Service
{
    public class UsuarioService
    {

        public Model.UsuarioModel Login(UsuarioModel _user)
        {
            var uri = "http://fiapcoin-webapi.azurewebsites.net/api/Auth";

            var conteudoJson = Newtonsoft.Json.JsonConvert.SerializeObject(_user);
            var conteudoJsonString = new StringContent(conteudoJson, Encoding.UTF8, "application/json");

            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.PostAsync(uri, conteudoJsonString).Result;

            if (resposta.IsSuccessStatusCode)
            {
                var resultado = resposta.Content.ReadAsStringAsync().Result;
                _user = JsonConvert.DeserializeObject<UsuarioModel>(resultado);
                return _user;
            }
            else
            {
                throw new Exception("Usuário não encontrado");
            }
        }


    }
}
