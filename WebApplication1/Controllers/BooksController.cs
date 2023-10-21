using Microsoft.AspNetCore.Mvc;
using WebApplication1.Exceptions;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/books")]
public class BookController : ControllerBase
{
    private readonly UserService _userService;

    public BookController(UserService userService)
    {
        _userService = userService;
    }


    [HttpGet]
    public List<UserModel> GetUsers()
    {
        throw new NotFoundException()
        {
            Message = "ahhahaha",
            StatusCode = 404
        };
        Console.WriteLine("this is from controller");
        return _userService.GetUsers();
    }
}