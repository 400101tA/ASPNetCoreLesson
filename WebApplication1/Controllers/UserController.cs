using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        var list = _context.Students
            .Include(student => student.Books)
            .Where(student => student.Id==1).ToList();

        foreach (var student in list)
        {
            Console.WriteLine(student.Name);
        }
        
        students.First().Name = "25-11-23";

        _context.SaveChanges();
        return _userService.GetUsers();
    }
    
    [HttpGet("{userId:int}")]
    public UserModel GetUserById(int userId)
    {
        
        // for (int i = 0; i < 20; i++)
        // {
        //     var next = Random.Shared.Next(1, 1000);
        //     _context.Students.Add(new()
        //     {
        //         Name = $"Test Name {next}",
        //         Books = new List<Book>()
        //         {
        //             new Book()
        //             {
        //                 Name = "alifbo"
        //             },
        //             new Book()
        //             {
        //                 Name = "C++"
        //             }
        //         }
        //     });
        // }

        var student = _context.Students.First(student => student.Id==1);

        _context.Students.Remove(student);
        
        _context.SaveChanges();
        return new UserModel();
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