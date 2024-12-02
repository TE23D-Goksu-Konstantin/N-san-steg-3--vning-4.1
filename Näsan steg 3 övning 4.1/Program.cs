using System;

class Program
{

    static int Triangle(int a, int b)
    {
        return(a - b);
    }

    static void Main(string[] args)
    {
                bool potato = true;

        while(potato == true){
        Console.WriteLine("Skriv en siffra som sedan ska subtraheras med en annan siffra som du skriver in.");
        string c = Console.ReadLine();


        if(int.TryParse(c, out int d))
        {
        Console.WriteLine(d);
        }else{
            Console.WriteLine("Fel!");
            continue;
        }

        bool tomato = true;
        while(tomato == true){
        Console.WriteLine("Skriv in den andra nu");
        string e = Console.ReadLine();

        if(int.TryParse(e, out int f))
        {
            Console.WriteLine(f);
        }else{
            Console.WriteLine("Fel!");
            continue;
        }
        

        Console.WriteLine(Triangle(d, f));
        Console.ReadLine();
        }
        }
    }
}