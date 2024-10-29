public class Model
{
    public string? Name {get; set; }

    public int Age {get; set; }

    public Model (string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"Name:{Name} Age:{Age}:";
    }
    //TODO: Verify that this actually does what we want it to when View is implemented.
}