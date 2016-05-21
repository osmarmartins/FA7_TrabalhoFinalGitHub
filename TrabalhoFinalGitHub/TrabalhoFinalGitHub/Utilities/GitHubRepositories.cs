using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinalGitHub.Utilities
{
    public class GitHubRepositories
    {
        // Método assincrono para retornar a relação de repositórios no 
        // GitHub de um determinado usuário.
        public async Task<List<string>> GetRepositories(string usuario)
        {
            var repositories = new List<string>();

            try
            {
                string url = "https://api.github.com/users/" + usuario + "/repos";
                var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("User-Agent", "Other");
                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var jsonRepositories = JArray.Parse(await response.Content.ReadAsStringAsync());

                    foreach (var repository in jsonRepositories)
                    {
                        repositories.Add(
                            repository.Value<string>("name") + " - " +
                            repository.Value<string>("language") + "\n" +
                            repository.Value<string>("description") + "\n");
                    }

                }
                else
                {
                    repositories.Add("Não foram encontrado projetos");
                }
            }
            catch
            {
                repositories.Add("Não foi possível conectar o GitHub");
            }

            return repositories;
        }
    }
}
