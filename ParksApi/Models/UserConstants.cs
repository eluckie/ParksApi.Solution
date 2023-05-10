namespace ParksApi.Models
{
  public class UserConstants
  {
    public static List<User> Users = new List<User> ()
    {
      // new User() { Username = "newUser", Password = "NewPassword1!", Email = "email@email.com", Name = "new user" },
      new User() { Username = "luckie", Password = "Password1!", Email = "email@email.com", Name = "Luckie" },
      new User() { Username = "adminTestUser", Password = "Password1!", Email = "email1@email.com", Name = "Admin User" },
      new User() { Username = "testUser", Password = "Password2!", Email = "email2@email.com", Name = "Test User" }
    };
  }
}  