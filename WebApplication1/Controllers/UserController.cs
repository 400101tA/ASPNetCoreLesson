using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Data.Entities;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly UserService _userService;
    private readonly MyDdContext _context;

    public UserController(UserService userService, MyDdContext context)
    {
        _userService = userService;
        _context = context;
    }

    [HttpGet]
    public List<UserModel> GetAllUsers()
    {
        var students = _context.Students.ToList();
        return _userService.GetUsers();
    }
    
    [HttpGet("{userId:int}")]
    public UserModel GetUserById(int userId)
    {
        var userModel = _userService.GetUsers().FirstOrDefault(model => model.Id==userId);

        if (userModel != null)
            return userModel;

        throw new ArgumentException("User not found");
    }

    [HttpDelete]
    [Route("{userId:int}")]
    public void DeleteUserById(int userId)
    {
        var userModel = _userService.GetUsers().FirstOrDefault(model => model.Id==userId);

        if (userModel != null)
            _userService.Remove(userModel);
    }

    [HttpPost]
    public UserModel CreateUser([FromBody] string name)
    {
      
        _context.Students.Add(new Student()
        {
            Name = "eshmat"
        });

        _context.SaveChanges();
        return null;
    }
    
}