using System.Text;
using WebApplication8.Database;
using WebApplication8.Models;
using System.Security.Cryptography;

public static class DatabaseSeeder
{
    public static void SeedData(AnantyaDbContext context)
    {
        if (!context.Register.Any())
        {
            var Password = "Admin@1298!2";

            var HashPash = HashPassword(Password);
            // Add default values if the table is empty
            var defaultValue = new Register { 
                Username= "Admin",
                Password = HashPash,
                Email = "262saurabhjhaa@gmail.com"
            };
            context.Register.Add(defaultValue);
            context.SaveChanges();
        }
    }
    public static string HashPassword(string password)
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            // ComputeHash - returns byte array
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

            // Convert byte array to a string
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2")); // Convert byte to its hexadecimal representation
            }
            return builder.ToString();
        }
    }
}

