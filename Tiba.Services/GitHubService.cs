using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Tiba.Services.Infractructure;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Tiba.Domain.Dto;
using Microsoft.AspNetCore.Authorization;

namespace Tiba.Services
{
    public class GitHubService : IGitHubService
    {
        private readonly IHttpClientFactory _clientFactory;

        public GitHubService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        [Authorize]
        public async Task<GitHubDTO> GetGitHubRepositories(string value)
        {
            var uri = new Uri("https://api.github.com/search/repositories?q=" + value);
            var client = _clientFactory.CreateClient("GitHub");
            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                //await response.Content.ReadAsStreamAsync().Result.ToString();
                var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(true);
                return JsonConvert.DeserializeObject<GitHubDTO>(responseBody.ToString());
            }
            else
            {
                return new GitHubDTO();
            }
        }
    }
}
