using WebApplication1.Models;

namespace WebApplication1.Services;

public class UserService
{
    private List<UserModel> UserModels { get; set; } = new()
    {
        new UserModel
        {
            Id = 1,
            Name = "Eshmatov Toshmat"
        },
        new UserModel
        {
            Id = 2,
            Name = "Firdavsi"
        }
    };
    
    public List<UserModel> GetUsers()
    {
        return UserModels;
    }

    public void Add(UserModel userModel)
    {
        UserModels.Add(userModel);
    }

    public void Remove(UserModel userModel) => UserModels.Remove(userModel);
}