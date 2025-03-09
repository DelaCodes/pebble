using System.Data;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using Pebble.WebApi.Models;

namespace Pebble.WebApi.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class UserController : Controller
{
    private readonly IConfiguration _configuration;

    public UserController(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    [HttpGet]
    public IActionResult GetAllUsers()
    {

        var connectionString = _configuration.GetConnectionString("DefaultConnection");
        
        using IDbConnection conn = new NpgsqlConnection(connectionString);
        if (conn.State != ConnectionState.Open) 
           conn.Open();
    
        var sql = "SELECT id, email, alias FROM users";
        var users = conn.Query<GetUserResponseDto>(sql);
        
        return Ok(users); 
    }
}