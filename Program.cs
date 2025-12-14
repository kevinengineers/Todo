using System;

string? userInput;
int? userInputValid = -1;

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
  } while (userInputValid != 0);

  Console.WriteLine("Exiting Program...");
}

PromptForTodoGreeting();





