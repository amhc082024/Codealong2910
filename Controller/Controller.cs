public class Controller
{
    // Inherit model and view classes, and create the objects _model and _view.
    Model _model;
    View _view;

    public Controller(Model model, View view)
    {
        _model = model;
        _view = view;
    }
    //Methods
    public void UpdateName()
    {
        Console.WriteLine("Write a new name:");
        string? newName = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(newName))
        {
            Console.WriteLine("Namme cannot be empty!/n");
        }
        else{
            _model.Name = newName;
        }
        //_model.name = newName;

    }
    public void UpdateAge()
    {
        // We parse the user input from ReadLine() as an integer, by taking a string input argument, and "Getting" a new integer outpur newAge
        Console.WriteLine("Write a new age:");
        if(int.TryParse(Console.ReadLine(), out int newAge))
        {
            _model.Age = newAge;
        }
    }
}
public void DisplayModel()

{
    _view.Display(_model);
}