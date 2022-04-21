using System;

namespace MyApp
{
    class Car
    {
        public Guid Id { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public DateOnly Date { get; set; }

        public override string ToString() =>
            @$"Id: {Id}
Make: {Make}
Model: {Model}
Date: {Date}
";
    }


    class CarGallery
    {
        public string? Name { get; set; }
        public Car[]? Cars { get; set; }

        public Car this[int index] // indexer
        {
            get => Cars[index];
            set => Cars[index] = value;
        }
    }

    partial class Program
    {
        static void Main1(string[] args)
        {
            CarGallery carGallery = new CarGallery();
            carGallery.Name = "Step";

            carGallery.Cars = new Car[]
            {
                new Car
                {
                    Id = Guid.NewGuid(),
                    Make ="Bmw",
                    Model="X6",
                    Date = new DateOnly(2020, 10, 1)
                },
                new Car {
                    Id = Guid.NewGuid(),
                    Make ="Kia",
                    Model="Cerato",
                    Date = new DateOnly(2013, 12, 8)
                }
            };


            foreach (var car in carGallery.Cars)
                Console.WriteLine(car);


            Console.WriteLine(carGallery[1]);

            carGallery[1] = new Car();
            Console.WriteLine(carGallery[1]);

        }
    }




    ////////////////////////////////////////////////////////////////

    class Matrix
    {
        public int[,] ArrayRect { get; set; }
        public int[][] ArrayJagged { get; set; }

        public int this[int index1, int index2]
        {
            get => ArrayRect[index1, index2];
            set => ArrayRect[index1, index2] = value;
        }

        public int[] this[int index]
        {
            get => ArrayJagged[index];
            set => ArrayJagged[index] = value;
        }
    }

    partial class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            matrix.ArrayRect = new int[2, 3]
            {
                {1, 2, 3 },
                {4, 5, 6 }
            };

            matrix.ArrayJagged = new int[][]
            {
                new int[3] {1, 2, 3},
                new int[4] {4, 5, 6, 7},
                new int[2] {8, 8}
            };

            Console.WriteLine(matrix[1, 1]);
            Console.WriteLine(matrix[1][3]);
        }
    }
}