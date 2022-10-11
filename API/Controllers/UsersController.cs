using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc; //model view controller
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //application program interface
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context) //dependency injection to get data from database
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers() //gets all users, ienumerable is like a fancy list
        {
            return await _context.Users.ToListAsync(); //Needs to be converted to async so the threads can multitask, if not it will only retrieve this one task one at a time
            //always use async, single threaded vs multi threaded, for scalibility
        }
       
       // api/users/3 -> get the user by the id of 3
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id) //gets all users, ienumerable is like a fancy list
        {
            return await _context.Users.FindAsync(id); //Find method finds a user with the primary key in the DB

            
        }
    }
}