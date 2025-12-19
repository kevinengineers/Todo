namespace TodoApp;

public class Todo(string name, string description)
{
    private readonly string _name = name;
    private readonly string _description = description;

    public string GetName()
    {
        return _name;
    }

    public String GetDescription()
    {
        return _description;
    }

}