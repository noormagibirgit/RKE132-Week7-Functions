
// loome funktsiooni mis prindib ükskõik mis sõna ekraanile täpselt 5 korda ja läbivate suurte tähtedega 


Console.WriteLine("Enter something");
string UserInput = Console.ReadLine();    // useInput - kasutaja sõna mis ta kirjutab 

PrintAnyWord(UserInput);  // userInput on argument 

static void PrintAnyWord(string anyString)  // anyString -parameeter , siis võib olla ükskõik mis sõna
{
    anyString = anyString.ToUpper();
    for (int i = 0; i < 5; i++)


    {
        Console.WriteLine(anyString);
    }

}