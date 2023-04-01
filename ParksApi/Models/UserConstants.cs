namespace ParksApi.Models
{
  public class UserConstants
  {
    public static List<User> Users = new List<User> ()
    {
      new User() { Username = "adminTestUser", Password = "Password1!", Email = "email1@emailcom", Name = "Admin User" },
      new User() { Username = "testUser", Password = "Password2!", Email = "email2@email.com", Name = "Test User" }
    };
  }
}  