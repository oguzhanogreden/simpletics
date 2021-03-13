using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication.Domain;
using WebApplication.Dtos;
using WebApplication.Extensions;
using ActionContext = WebApplication.DbContexts.ActionContext;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActionController : ControllerBase
    {
        private readonly ILogger<ActionController> _logger;
        private readonly ActionContext _context;

        public ActionController(ILogger<ActionController> logger, ActionContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> RecordAction([FromBody] RecordActionApiRequest request)
        {
            var action = request.ToDomain();
            
            _context.Actions.Add(action);
            await _context.SaveChangesAsync();
            
            return Ok();
        }
    }
}