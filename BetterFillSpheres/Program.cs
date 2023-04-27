using System;

namespace BetterFillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 2 spheres
            Sphere sphere1 = new Sphere{Color = new Color{Red = 255, Green = 0, 
                             Blue = 0, Alpha = 50}, Radius = 10};
            Sphere sphere2 = new Sphere{Color = new Color{Red = 0, Green = 255,
                             Blue = 0}, Radius = 20};

            // Throw them
            sphere1.Throw();
            sphere2.Throw();

            // Pop them
            sphere1.Pop();

            // Print their state to the console
            Console.WriteLine("Sphere 1 color: " + sphere1.Color.Red + ", " + 
                              sphere1.Color.Green + ", " + sphere1.Color.Blue + 
                              ", " + sphere1.Color.Alpha + " | Sphere 1 radius: " +
                              sphere1.Radius + " | Sphere 1 times thrown: " +
                              sphere1.GetTimesThrown);
            Console.WriteLine("Sphere 2 color: " + sphere2.Color.Red + ", " +
                              sphere2.Color.Green + ", " + sphere2.Color.Blue +
                              ", " + sphere2.Color.Alpha + " | Sphere 2 radius: " +
                              sphere2.Radius + " | Sphere 2 times thrown: " +
                              sphere2.GetTimesThrown);

            // Print name of color from spheres
            Console.WriteLine("Sphere 1 color name: " + sphere1.Color.Name);
            Console.WriteLine("Sphere 2 color name: " + sphere2.Color.Name);

            // Change color from sphere 1
            sphere1.Color = new Color{Red = 0, Green = 0, Blue = 255, Alpha = 255};

            // Print their state to the console
            Console.WriteLine("Sphere 1 color: " + sphere1.Color.Red + ", " + 
                              sphere1.Color.Green + ", " + sphere1.Color.Blue + 
                              ", " + sphere1.Color.Alpha + " | Sphere 1 radius: " +
                              sphere1.Radius + " | Sphere 1 times thrown: " +
                              sphere1.GetTimesThrown);

            // Print name of color from sphere 1
            Console.WriteLine("Sphere 1 color name: " + sphere1.Color.Name);

        }
    }
}
