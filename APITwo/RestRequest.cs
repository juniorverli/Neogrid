using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Threading.Tasks;

//public double juros;

namespace APITwo
{

    public static class RestRequest
    {
        public static double Juros { get; set; }

        public static bool GetJurosError { get; private set; }

        public static async Task GetRequestJuros(string url)
        {

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                using (HttpResponseMessage response =  await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string mycontent = await content.ReadAsStringAsync();
                            HttpContentHeaders headers = content.Headers;
                            var myObject = JObject.Parse(mycontent);
                            Juros = Convert.ToDouble(myObject.SelectToken(".juros"));
                        }
                        else
                        {
                            GetJurosError = true;
                        }
                    }
                }
            }
        }
    }
}
