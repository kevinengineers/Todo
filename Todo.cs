public class Todo
{
    private string name;
    private string description;

    public Todo(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public string GetName()
    {
        return this.name;
    }

    public String GetDescription()
    {
        return this.description;
    }

}