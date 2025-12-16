using System;
using System.Globalization;

string? userInput;
int? userInputValid = -1;
var todos = new Todo[100];
var i = 0;

Todo[] GetTodos()
{
  return todos;
}

void AddTodo(Todo todo)
{
  // Find first index of null items.
  int index = 0;

  for (int j = 0; j < todos.Length; j++)
  {
    if (todos[j] == null)
    {
      index = j;
      break;
    }
  }

  todos[index] = todo;

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

PromptForTodoGreeting();






