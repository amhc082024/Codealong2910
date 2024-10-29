public class View
{
    public void Display()
    {
        Console.WriteLine(Model.ToString());
    }

    public void DisplayMessage(string message)
    {
        Console.WriteLine($"{message}");
    }
}