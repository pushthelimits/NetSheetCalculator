// Net Sheet Calculator program
// Calculates Net sheet special pricing
using System;

public class NetSheets
{
   // Main method begins execution of C# app
   public static void Main(string[] args)
   {
      decimal NetSheetPrice; // declare the NetSheetPrice amount
      decimal LocationMultiplier; // declare the Location Multiplier
      decimal UnitCostTotal; // delcare the Internal Marketplace Unit Cost Total from the Test Dealer quote
      decimal SlabListPrice;  // declare the Slab List Price from the Test Dealer quote
      decimal SpecialPrice; // declare the Net sheet special pricing

      Console.Write("Enter the Net Sheet Price: "); // prompt user
      // read first number from user
      NetSheetPrice = Convert.ToDecimal(Console.ReadLine());

      Console.Write("Enter the Dealer Location Cost Multiplier: "); //prompt user
      // read second number from user
      LocationMultiplier = Convert.ToDecimal(Console.ReadLine());

      Console.Write("Enter the Internal MP Unit Cost Total (branch Test Dealer): "); // prompt user
      // read third number from user
      UnitCostTotal = Convert.ToDecimal(Console.ReadLine());

      Console.Write("Enter the Internal MP Slab List Price (branch Test Dealer): "); // prompt user
      // read the fourth number from user
      SlabListPrice = Convert.ToDecimal(Console.ReadLine());

      SpecialPrice = (SlabListPrice - (UnitCostTotal - (NetSheetPrice / LocationMultiplier)));  //calculate Net Sheet special pricing

      Console.WriteLine("\n\nSpecial Net Sheet Pricing is:\n\n {0}", SpecialPrice); // display Net Sheet special pricing

      Console.Write("\n\nPress Enter to close..."); // Interts two lines breaks and tells the user how to close the app
      Console.Read(); //keeps the console window open after it's run
   } // end Main
} // end class NetSheetCalculator