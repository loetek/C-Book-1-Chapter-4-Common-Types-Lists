using System;
using System.Collections.Generic;

namespace Planets_Lists
{
    class Program
    {
        static void Main()
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

           // planetList.ForEach(planets => Console.WriteLine(planets));

            List<string> planetList2 = new List<string>(){"Uranus"};


            planetList.AddRange(planetList2);


            planetList.Insert(2, "Venus");
            planetList.Insert(3, "Earth");

            planetList.Add("Pluto");


            string[] rockyPlanets = planetList.GetRange(0,3).ToArray();

            //rockyPlanets.ForEach(planets => Console.WriteLine(planets));

            planetList.Remove("Pluto");
            planetList.ForEach(planets => Console.WriteLine(planets));


        }
    }
}
