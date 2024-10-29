﻿namespace Codealong2910;

class Program
{
    static void Main(string[] args)
    {
        // we initialize new instances of our MVC classes.
        Model model = new Model("KentJonny", 23);
        View view = new View();
        Controller controller = new Controller(model, view);

        //we use the controller to test our program.
        controller.DisplayModel();

        // Use the Readline() to stall the program and keep it running.
        Console.ReadLine();

        Console.WriteLine("Hello, World!");
    }
}