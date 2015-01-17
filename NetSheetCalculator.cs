// Net Sheet Calculator program
// Calculates Net sheet special pricing
using System;

public class NetSheets
{
   // Main method begins execution of C# app
   public static void Main(string[] args)
   {
      decimal netSheetPrice; // declare the Net Sheet price amount
      decimal locationMultiplier; // declare the Location Multiplier
      decimal unitCostTotal; // delcare the Internal Marketplace Unit Cost Total from the Test Dealer quote
      decimal slabListPrice;  // declare the Internal Marketplace Slab List Price from the Test Dealer quote
      decimal specialPrice; // declare the Net Sheet special pricing

      Console.Write("Enter the Net Sheet Price: "); // prompt user
      // read first number from user
      netSheetPrice = Convert.ToDecimal(Console.ReadLine());

      Console.Write("Enter the Dealer Location Cost Multiplier: "); //prompt user
      // read second number from user
      locationMultiplier = Convert.ToDecimal(Console.ReadLine());

      Console.Write("Enter the Internal MP Unit Cost Total (branch Test Dealer): "); // prompt user
      // read third number from user
      unitCostTotal = Convert.ToDecimal(Console.ReadLine());

      Console.Write("Enter the Internal MP Slab List Price (branch Test Dealer): "); // prompt user
      // read the fourth number from user
      slabListPrice = Convert.ToDecimal(Console.ReadLine());

      specialPrice = (slabListPrice - (unitCostTotal - (netSheetPrice / locationMultiplier)));  //calculate Net Sheet special pricing

      Console.WriteLine("\n\nSpecial Net Sheet Pricing is:\n\n {0}", specialPrice); // display Net Sheet special pricing

      Console.Write("\n\nPress Enter to close..."); // inserts two line breaks and tells the user how to close the app
      Console.Read(); // keeps the console window open after the app is done executing
   } // end Main
} // end class NetSheets