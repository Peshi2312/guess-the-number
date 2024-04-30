Random randomnumber = new Random();
int computernumber = randomnumber.Next(1, 101);
while (true)
{
    Console.Write($"Guess a number (1-100): ");
    string playerInput = Console.ReadLine();
    bool isValid = int.TryParse(playerInput, out int playerNumber);
    if (isValid)
    {
        if (playerNumber == computernumber)
        {
            Console.WriteLine("You guessed it!");
            break;
        }
        else if (playerNumber > computernumber)
        {
            Console.WriteLine("Too High");
        }
        else
        {
            Console.WriteLine("Too Low");
        }
    }
}