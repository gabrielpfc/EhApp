using System;
using System.Collections.Generic;
using System.Net.Http;
using EhApp.Model;
using Newtonsoft.Json;

namespace EhApp.Layers.Service
{
    public class PerfilService
    {
        public IList<TreinoModel> Get()
        {
            var uri = "http://fiapcoin-webapi.azurewebsites.net/api/Perfil/";

            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.GetAsync(uri).Result;

            if (resposta.IsSuccessStatusCode)
            {
                var resultado = resposta.Content.ReadAsStringAsync().Result;
                var Treino = JsonConvert.DeserializeObject<IList<TreinoModel>>(resultado);
                return Treino;
            }
            else
            {
                throw new Exception("Treino não encontrados!");
            }

        }
    }
}
