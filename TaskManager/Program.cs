using TaskManager;

MethodClass methods = new();

while (true)
{
repeat:
    Console.WriteLine("Enter 1 to add a task or 2 to print the tasks, or any other number to exit:");
    int input;
    if (!int.TryParse(Console.ReadLine(), out input)) goto repeat;

    switch (input)
    {
        case 1:
            methods.InitializeBaseClass();
            break;

        case 2:
            methods.PrintTask();
            break;

        default:
            // Exit the loop for any other input
            return;
    }
}