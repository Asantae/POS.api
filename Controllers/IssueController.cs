using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POS.Data;
using POS.Models;

namespace IssueController;

[Route("api/[controller]")]
[ApiController]
public class IssueController : ControllerBase
{
    private readonly IDbContext _context;
    public IssueController(IDbContext context) => _context = context;
    [HttpGet]
    public async Task<IEnumerable<Issue>> Get() => await _context.Issues.ToListAsync();
}