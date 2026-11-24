using System;
using System.Linq;

internal class User
{
    private string phone;

    public User(string name, string phoneNumber, string password)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Password = password;
    }

    public string Name { get; set; }

    public string PhoneNumber
    {
        get { return phone; }
        set
        {
            if (!string.IsNullOrEmpty(value) && value.Length == 11 && value.All(char.IsDigit))
            {
                phone = value;
            }
            else
            {
                Console.WriteLine("phone must be 11 numbers");
            }
        }
    }

    public string Password { get; private set; }
}