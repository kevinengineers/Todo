using System.Runtime.InteropServices.Swift;

namespace TodoApp;

public class TodoStore
{
    private Todo?[] _todos = new Todo[100];

    public Todo?[] GetTodos()
    {
        return _todos;
    }


    public void PrintTodos()
    {
        foreach (var todo in _todos)
        {
            if (todo == null)
            {
                continue;
            }

            Console.WriteLine($"{todo.GetName()}, {todo.GetDescription()}");
        }
    }
    
    public void AddTodo(Todo todo)
    {
        // Find first index of null items.
        var index = 0;

        for (var j = 0; j < _todos.Length; j++)
        {
            if (_todos[j] == null)
            {
                index = j;
                break;
            }
        }
        Console.WriteLine($"adding {todo.GetName()} at index: {index}");
        _todos[index] = todo;
    }
    
    
    
    public void CreateNewTodo()
    {
  
        Console.Write("Enter TodoApp name: ");
        var todoName = Console.ReadLine();
  
        Console.Write("Enter description: ");
        var todoDescription = Console.ReadLine();

        if (todoName == null || todoDescription == null)
        {
            Console.WriteLine("Error, invalid input given for todo, please restart the program");
            return;
        }
  
        var newTodo = new Todo(todoName, todoDescription);
        AddTodo(newTodo);
  
        Console.WriteLine("Added new todo");
    }
}