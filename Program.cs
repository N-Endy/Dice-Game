// Die is rolled in the background. The number is stored and the console shows the below prompt.
// "Die rolled. Guess what number it shows in 3 tries."
// "Enter a number:"

// If the number inputted is same as die rolled, the prompt below is shown.
// "You win!"

// If the number is wrong, the user is prompted to input another number again.
// "Wrong number."
// "Enter a number:"

// If invalid number is inputted, user is prompted to enter another number again
// "Enter a number:"

// If number of tries is exhausted, the game exits immediately, after displaying the below prompt.
// "You lose :("

// Classes
// Prompter(Displays the prompt messages)
// DiceRoller (Rolls dice)
// NumberValidator (Validates the number)

NumberValidator numberValidator = new();
int numberOfAttempts = 3;
Console.WriteLine($"Die rolled. Guess what number it shows in {numberOfAttempts} tries.");
string userInput;

bool guess = false;
while (numberOfAttempts > 0 && !guess)
{
    // Check if number is valid number
    do
    {
        Console.WriteLine("Enter a number: ");
        userInput = Console.ReadLine();
    }
    while (!numberValidator.IsNumber(userInput));

    // Check if number is equal to rolled die number
    if (numberValidator.Validate(int.Parse(userInput)))
    {
        Console.WriteLine("You win!");
        guess = true;
    }
    else
    {
        Console.WriteLine("Wrong number.");
    }

    numberOfAttempts--;
}

if (numberOfAttempts == 3 && !guess)
{
    Console.WriteLine("You lose :(");
}