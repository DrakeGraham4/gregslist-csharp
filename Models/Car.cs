using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gregslist_csharp.Models
{
    public class Car
    {
        public string Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int? Year { get; set; }

        public Car(string make, string model, int? year)
        {
            Id = Guid.NewGuid().ToString();
            Make = make;
            Model = model;
            Year = year;
        }
    }
}