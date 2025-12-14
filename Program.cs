using System;

string? userInput;
int? userInputValid = -1;
var todos = new Todo[100];
var i = 0;

Todo[] GetTodos()
{
  return todos;
}


void PromptForTodoGreeting()
{
  do
  {
    Console.WriteLine("Make a selection: ");
    Console.WriteLine("1. List Todos:");
    Console.WriteLine("2. Remove a Todo:");
    Console.WriteLine("3. Complete a Todo:");
    Console.WriteLine("0. Exit Program");
    Console.Write("Selection: ");
    userInput = Console.ReadLine();
    

    if (userInput != null)
    {
      userInputValid = int.Parse(userInput);
    }
    if (userInputValid == 1)
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
  } while (userInputValid != 0);

  Console.WriteLine("Exiting Program...");
}

void testData()
{
  for (int j = 0; j < 10; j++)
  {
    var todo = new Todo("Clean something", "clean something before susie gets home");
    todos[j] = todo;
  }
}

testData();
PromptForTodoGreeting();





