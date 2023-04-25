using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Urbanyo.API.Data;
using Urbanyo.Shared.Entities;

namespace Urbanyo.API.Controllers
{
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("/api/QuestionConstruction")]
    public class QuestionConstructionController : ControllerBase
    {

        public readonly DataContext _context;

        public QuestionConstructionController(DataContext context)
        {
            _context = context;
        }
        
        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var questCons = await _context.QuestionConstructions
                .Include(x => x.ProjectTypeId)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (questCons == null)
            {
                return NotFound();
            }

            return Ok(questCons);
        }
        [HttpPost]
        public async Task<ActionResult> PostAsync(State questCons)
        {

            try
            {
                _context.Add(questCons);
                await _context.SaveChangesAsync();
                return Ok(questCons);
            }
            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("Ya existe un Estado/Departamento con el mismo nombre.");
                }
                else
                {
                    return BadRequest(dbUpdateException.Message);
                }
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

    }
}
