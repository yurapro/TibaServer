using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Tiba.Domain.Dto;
using Tiba.Services.Infractructure;
using Web.Models.GitHub;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GitHubController : ControllerBase
    {
        private readonly ILogger<GitHubController> _logger;
        private readonly IGitHubService _gitHubService;

        public GitHubController(ILogger<GitHubController> logger , IGitHubService gitHubService)
        {
            _logger = logger;
            _gitHubService = gitHubService;
        }

        [Authorize]
        [HttpGet("{value}")]
        public async Task<GitHubDTO> Get(string value)
        {
            try
            {
                return await _gitHubService.GetGitHubRepositories(value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
