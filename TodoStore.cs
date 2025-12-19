using System.Runtime.InteropServices.Swift;

namespace TodoApp;

public class TodoStore
{
    private readonly Todo?[] _todos = new Todo[100];
    private int _index = 0;

    public Todo?[] GetTodos()
    {
        return _todos;
    }


    public void PrintTodos()
    {
        for (var i = 0; i < _todos.Length; i++)
        {
            var todo = _todos[i];
            
            if (todo == null)
            {
                continue;
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"{i}. Name: {todo.GetName()}, Desc: {todo.GetDescription()} ");
            Console.WriteLine("----------------------------------------");
        }
    }
    
    private void AddTodo(Todo todo)
    {
        for (var j = 0; j < _todos.Length; j++)
        {
            if (_todos[j] == null)
            {
                _index = j;
                break;
            }
        }
        
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"adding {todo.GetName()}");
        Console.WriteLine("----------------------------------------");
        
        _todos[_index] = todo;
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

    public void DeleteTodo()
    {
        Console.Write($"Enter the number of the Todo to delete: ");
        
        string? deleteAtIndex = Console.ReadLine();
        
        if (int.TryParse(deleteAtIndex, out var deleteIndex))
        {
            if (deleteIndex >= 0)
            {
                var todo = _todos[deleteIndex];

                if (todo != null)
                {
                    
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"Deleting {todo.GetName()}");
                    Console.WriteLine("----------------------------------------");
                    _todos[deleteIndex] = null;
                }
            }
        };
    }
}