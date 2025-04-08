namespace SmartHome.Models;

public class User
{
    public int Uid { get; private set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public User(int uid, string username, string password)
    {
        Uid = uid;
        Username = username;
        Password = password;
    }
}