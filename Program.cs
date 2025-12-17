string? userInput;
int? userInputValid = -1;
var todos = new Todo[100];
var i = 0;

void GetTodos()
{
  foreach (var todo in todos)
  {
    if (todo != null)
    {
      Console.WriteLine($"Todo: {i + 1}: {todo.GetName()}, {todo.GetDescription()}");
      i++;
    }
  }
}

void AddTodo(Todo todo)
{
  // Find first index of null items.
  var index = 0;

  for (var j = 0; j < todos.Length; j++)
  {
    if (todos[j] == null)
    {
      index = j;
      break;
    }
  }

  todos[index] = todo;

}

void CreateNewTodo()
{
  
  Console.Write("Enter Todo name: ");
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


void PromptForTodoGreeting()
{
  do
  {
    Console.WriteLine("Make a selection: ");
    Console.WriteLine("1. List Todos:");
    Console.WriteLine("2: Add a Todo:");
    Console.WriteLine("3. Delete a Todo:");
    Console.WriteLine("0. Exit Program");
    Console.Write("Selection: ");
    userInput = Console.ReadLine();


    while (userInput == null)
    {
      Console.Write("Invalid input, please enter a valid selection: ");
      userInput = Console.ReadLine();
    }
    userInputValid = int.Parse(userInput);

    switch (userInputValid)
    {
      case 1:
        GetTodos();
        break;
      case 2:
        CreateNewTodo();
        break;
      default:
        Console.WriteLine("Invalid input, please make a valid selection...");
        break;
    }
  } while (userInputValid != 0);

  Console.WriteLine("Exiting Program...");
}

PromptForTodoGreeting();






