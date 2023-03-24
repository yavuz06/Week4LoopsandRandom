
Random rnd = new Random();
int cpurandom = rnd.Next(1, 11);

int nooftries = 0;


while (nooftries < 3)
{
    Console.WriteLine("try to guess the cpu number:");
    int userguess = Convert.ToInt32(Console.ReadLine());
    nooftries++;
    
    if(userguess == cpurandom) 
    {
        Console.WriteLine("you won");
        break;
    }
    
}
Console.WriteLine($"number of tries:{nooftries}");
Console.WriteLine("have a nice day");
