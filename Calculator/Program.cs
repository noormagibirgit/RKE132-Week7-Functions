

Console.WriteLine("Enter the operation (+/-):");
char userOperator = Char.Parse(Console.ReadLine());


Console.WriteLine("Enter a:");
int firstNum = Int32.Parse(Console.ReadLine());// firstNum argument 
Console.WriteLine("Enter b:");
int secondNum = Int32.Parse(Console.ReadLine());    

switch(userOperator) // kontrollime mis operaatori on kasutaja valinud, kui valis + , siis läheb käima Addition ehk liitmine 

{
    case '+':
        Addition(firstNum, secondNum); // firstNum ehk a ja secondNum ehk b 
        break;

    case '-':
        Subtraction(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("Invalid operator");
        break;
}

static void Addition(int a, int b)  // liitmine

{
    Console.WriteLine($"{a} + {b} = {a + b}");

}
 
static void Subtraction(int a, int b)    // lahutamine 


{
    Console.WriteLine($"{a} - {b} = {a - b}");

}
