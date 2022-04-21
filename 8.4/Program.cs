using System;
using System.Text.Json;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User[] users = {
                new User{ Username = "Leyla", Password="Leyla123" },
                new User{ Username = "Aga", Password="Aga1234" }
            };



            var options = new JsonSerializerOptions();
            options.WriteIndented = true;

            var jsonString = JsonSerializer.Serialize(users, options);
            File.WriteAllText("users.json", jsonString);

            Console.WriteLine(jsonString);
            var text = File.ReadAllText("users.json");
            User[]? usersREAD = JsonSerializer.Deserialize<User[]>(text);

            foreach (var user in usersREAD)
            {
                Console.WriteLine(user.Username);
                Console.WriteLine(user.Password);
            }
        }
    }
}