// allahindluse arvutamine . Kasutaja ostab midagi ja arve summa on

// total 10 < -1%   väikem kui 10 siis allahindlus on 1 %
// total >= 10 && > 20   - allahindlus 5 % 
// total >= 20 - allahindlus on 10 % 

Console.WriteLine("Provide total:");
int userInput = Int32.Parse(Console.ReadLine());  // ehk võta see sõna mis kasutaja kirjutab ja muuda see arvuks 

double discount = CalculateDiscaount(userInput);

Console.WriteLine($"Your discount is: {discount}%");

double newTotal = CalculatedNewTotal(userInput, discount);

Console.WriteLine($"Your updated total with {discount}%: {newTotal}");

static double CalculateDiscaount(int total) // static double kui funktsioon lõpetab töö, siis vahemälusse jääb väärtus alles ja nniöelda jätkab. Void kustutatakse 
    // int total on summa mille saan kasutaja käest

{
    if(total < 10 ) 
    {
        return 1;
    }
    else if(total >= 10 && total < 20 )
    {
        return 5;
    }
    else
    {
        return 10;
    }

}

static double CalculatedNewTotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
}



