using System;

Console.WriteLine("Welcome to the Number Analyzer!");
Console.Write("Please enter your name: ");
string userName = Console.ReadLine();

bool continueAnalyzing = true; // Control variable for the main loop

// Main loop to allow analyzing multiple numbers
while (continueAnalyzing)
{
    // Prompt the user for a valid number input
    int userNumber = GetValidNumber(userName);

    // Analyze the entered number and print the result
    AnalyzeNumber(userNumber);

    // Ask the user if they want to continue analyzing numbers
    continueAnalyzing = PromptContinue(userName);
}

Console.WriteLine("Thank you for using the Number Analyzer! Goodbye!");

// Method to get a valid integer between 1 and 100 from the user
int GetValidNumber(string userName)
{
    int number = 0;
    bool validInput = false;

    while (!validInput)
    {
        Console.Write($"{userName}, please enter an integer between 1 and 100 inclusive: ");
        string input = Console.ReadLine();

        // Validate that the input is an integer within the range
        if (int.TryParse(input, out number) && number >= 1 && number <= 100)
        {
            validInput = true; // Input is valid if it’s an integer within the range
        }
        else
        {
            Console.WriteLine("Invalid input. Make sure you enter a number between 1 and 100.");
        }
    }

    return number;
}

// Method to analyze and display the result based on the integer entered
void AnalyzeNumber(int number)
{
    if (number % 2 != 0) // Check if the number is odd
    {
        if (number < 60)
        {
            Console.WriteLine($"{number} is Odd and less than 60.");
        }
        else
        {
            Console.WriteLine($"{number} is Odd and greater than 60.");
        }
    }
    else // The number is even
    {
        if (number >= 2 && number <= 24)
        {
            Console.WriteLine("Even and less than 25.");
        }
        else if (number >= 26 && number <= 60)
        {
            Console.WriteLine("Even and between 26 and 60 inclusive.");
        }
        else if (number > 60)
        {
            Console.WriteLine($"{number} is Even and greater than 60.");
        }
    }
}

// Method to prompt the user if they want to continue analyzing numbers
bool PromptContinue(string userName)
{
    while (true)
    {
        Console.Write($"{userName}, would you like to analyze another number? (yes/no): ");
        string response = Console.ReadLine().Trim().ToLower();

        if (response == "yes")
        {
            return true;
        }
        else if (response == "no")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Please enter 'yes' or 'no'.");
        }
    }
}