

Console.WriteLine("Are you coming or leaving? (in/out):");

string userChoice = Console.ReadLine();

    if(userChoice == "in")
{
    PrintHello();
}
    else

{
    PrintGoodBye();

}


static void PrintHello()  // fuktsioon või ka meetodi välja kutsumine . sulud lõpus tähendavad, et tee midagi, ehk prindi välja.
{
    Console.WriteLine("Hello, World!");

}

static void PrintGoodBye()
{
    Console.WriteLine("See you later");

}