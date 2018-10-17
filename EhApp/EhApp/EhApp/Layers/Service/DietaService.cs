using System;
using System.Collections.Generic;
using System.Net.Http;
using EhApp.Model;
using Newtonsoft.Json;

namespace EhApp.Layers.Service
{
    class DietaService
    {
        public Model.DietaModel IdDieta(DietaModel _id)
        {
            var uri = "http://fiapcoin-webapi.azurewebsites.net/api/Auth";

            var conteudoJson = Newtonsoft.Json.JsonConvert.SerializeObject(_id);
            var conteudoJsonString = new StringContent(conteudoJson, Encoding.UTF8, "application/json");

            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.PostAsync(uri, conteudoJsonString).Result;

            if (resposta.IsSuccessStatusCode)
            {
                var resultado = resposta.Content.ReadAsStringAsync().Result;
                _id = JsonConvert.DeserializeObject<DietaModel>(resultado);
                return _id;
            }
            else
            {
                throw new Exception("Dieta não registrada");
            }
        }

    }
}
