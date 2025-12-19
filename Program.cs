using TodoApp;

string? userInput;
int? userInputValid = -1;
var todoStore = new TodoStore();

void PromptForTodoGreeting()
{
  do
  {
    Console.WriteLine("Make a selection: ");
    Console.WriteLine("1. List Todos:");
    Console.WriteLine("2: Add a TodoApp:");
    Console.WriteLine("3. Delete a TodoApp:");
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
        todoStore.PrintTodos();
        break;
      case 2:
        todoStore.CreateNewTodo();
        break;
      case 3:
        todoStore.DeleteTodo();
        break;
      default:
        Console.WriteLine("Invalid input, please make a valid selection...");
        break;
    }
  } while (userInputValid != 0);

  Console.WriteLine("Exiting Program...");
}

PromptForTodoGreeting();






