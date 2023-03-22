namespace PrimeNumber;

public static partial class Math
{
  public static bool isPrime(this in int number) {
    if(number < 2)
      return false;
    
    for(int x = 2; x < number; x++)
      if((number % x) == 0)
        return false;
    
    return true;
  }
}