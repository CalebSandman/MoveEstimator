using System;

class Program {
  public static void Main (string[] args) {

    //Malcolm Movers rates
    const int hourRate = 150;
    const int mileRate = 2;
    const int flatRate = 200;
    
    //prompts user for estimated hours
    Console.WriteLine("Enter the estimated hours:");
    var inputtedHours = Console.ReadLine();

    //prompts user for estimated miles
    Console.WriteLine("Enter the estimated miles:");
    var inputtedMiles = Console.ReadLine();

    //vars for checking if input was a number
    double estimatedHours;
    double estimatedMiles;

    //converts inputted hours to a double and provides an error message if the input was not a     number
    if(double.TryParse(inputtedHours, out estimatedHours) && double.TryParse(inputtedMiles,        out estimatedMiles))
    {
      Console.WriteLine("The estimated cost is ${0}", (estimatedHours * hourRate) +     
      (estimatedMiles * mileRate) + flatRate);
    }
    else
    {
      Console.WriteLine("Invalid input");
    }
  }
}