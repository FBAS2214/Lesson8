using System;

namespace MyApp
{
    class World
    {
        public string[][] CountriesCapitals { get; set; }

        public string? this[string country]
        {
            get {
                foreach (var arr in CountriesCapitals)
                    if(arr[0] == country)
                        return arr[1];

                return null;
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            World world = new World();

            world.CountriesCapitals = new string[][]{
                new string[2] { "Azerbaijan", "Baku"},
                new string[2] { "Turkey", "Ankara"}
            };


            Console.WriteLine(world["Azerbaijan"]);
        }
    }
}