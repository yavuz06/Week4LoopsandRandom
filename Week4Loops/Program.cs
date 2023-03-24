
using System;

Random rnd = new Random();
int myrandom;

for (int i = 0; i<3 ; i++)
{
    myrandom = rnd.Next(1, 11);
    Console.WriteLine(myrandom);
}

//for (int i = 0; i < 5; i++) 
//{
//    Console.WriteLine($"{i +1}. i will not skip class again");
//}
