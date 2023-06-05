void PrintDivisibleNumbers(int num = 100)
{
    for(int i =1; i <= num; i++)
    {
    bool isDivisibleBy3 = i % 3 == 0;
    bool isDivisibleBy5 = i % 5 == 0;
    bool isDivisibleBy3And5 = isDivisibleBy3 &&  isDivisibleBy5;
    if(isDivisibleBy3And5)
    {
        System.Console.WriteLine("FizzBuzz");
    }
    else if(isDivisibleBy3)
    {
        System.Console.WriteLine("Fizz");
    }
    else if(isDivisibleBy5){
        System.Console.WriteLine("Buzz");
    }
    else
    {
        System.Console.WriteLine(i);
    }
    }

}

PrintDivisibleNumbers();
System.Console.WriteLine("================");
PrintDivisibleNumbers(25);