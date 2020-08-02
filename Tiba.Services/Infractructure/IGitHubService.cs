using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tiba.Domain.Dto;

namespace Tiba.Services.Infractructure
{
    public interface IGitHubService
    {
        Task<GitHubDTO> GetGitHubRepositories(string quary);
    }
}
