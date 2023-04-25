using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Urbanyo.API.Data;
using Urbanyo.Shared.Entities;
namespace Urbanyo.API.Controllers   
{
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("/api/categories")]
    public class ProjectController: ControllerBase
    {
        public readonly DataContext _context;
        public ProjectController(DataContext context)
        {
            _context = context;
         
        }

    }
}
