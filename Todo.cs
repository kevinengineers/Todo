namespace TodoApp;

public class Todo
{
    private string _name;
    private string _description;

    public Todo(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public string GetName()
    {
        return _name;
    }

    public String GetDescription()
    {
        return _description;
    }

}