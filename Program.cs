string? todoInput = null;
string[] todoArray = new string[100];
void promptForTodoGreeting()
{
  Console.WriteLine("Hello, this is a Todo app, written in C#");
  Console.Write("Enter your first Todo: ");
  todoInput = Console.ReadLine();
}

String[] getCurrentTodos()
{
  return todoArray; 
}

void printCurrentTodos()
{
  //FIXME: This is wrong. The array is initalized with 100 null items, fix this so if the item is null
  // it doesn't print the item out.
  if (todoArray.Length > 0)
  {
    foreach (string todo in todoArray)
    {
       Console.WriteLine($"Todo: {todo}");
    }
  }
}

promptForTodoGreeting();
printCurrentTodos();


