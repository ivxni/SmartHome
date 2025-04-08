namespace SmartHome.Models;

public class Light : Device
{
    public Light(int id, string name, string type, bool connected)
    {
        Id = id;
        Name = name;
        Type = "Light";
        Connected = true;
    }
}