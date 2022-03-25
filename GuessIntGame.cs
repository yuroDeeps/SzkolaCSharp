//const==final
//const int number = 0;

//simple "guess number between 1-10" code
Console.WriteLine("Zgadnij liczbe od 1 do 10!");

//peak pseudo-random int in range 1;10
Random random = new Random();
int randomInt = random.Next(1, 10);

String input;
int playerGuess;

// get number from player, end when player pick 0 or same number as 'randomInt'. Loop will inform if input is grater or smaller than 'randomInt'
do
{
    Console.WriteLine("\nJeżeli chcesz zakończyć wpisz 0!");
    Console.WriteLine("\nPodaj wybrana przez siebie liczbe: ");

    input = Console.ReadLine();
    playerGuess = int.Parse(input);

    if (playerGuess.Equals(randomInt))
    {
        Console.WriteLine("Brawo, odgadles liczbe!!!");
        break;
    }
    else if (playerGuess > randomInt)
    {
        Console.WriteLine("Twoja liczba jest wieksza niz poprawna odpowiedz.");
    }
    else if (playerGuess < randomInt)
    {
        Console.WriteLine("Twoja liczba jest mniejsza niż poprawna odpowiedz.");
    }
} while (!playerGuess.Equals(0));

// end of the game
Console.WriteLine("Zakonczono gre.");
