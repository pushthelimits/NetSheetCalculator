// Net Sheet Calculator program
// Calculates Net Sheet special pricing
using System;

public class NetSheets
{
   // Main method begins execution of C# app
   public static void Main(string[] args)
   {
      // loop that keeps the application running until the user chooses to close it
      do{
      decimal netSheetPrice; // declare the Net Sheet price amount
      decimal locationMultiplier; // declare the Location Multiplier
      decimal unitCostTotal; // delcare the Internal Marketplace Unit Cost Total from the Test Dealer quote
      decimal slabListPrice;  // declare the Internal Marketplace Slab List Price from the Test Dealer quote
      decimal specialPrice; // declare the Net Sheet special pricing

      // prompt user for the net sheet price and read the number
      Console.Write("\n\nEnter the Net Sheet Price: ");
      netSheetPrice = Convert.ToDecimal(Console.ReadLine());

      // prompt user for the dealer location cost multiplier and read the number
      Console.Write("Enter the Dealer Location Cost Multiplier: ");
      locationMultiplier = Convert.ToDecimal(Console.ReadLine());

      // prompt user for the internal mp unit cost total and read the number
      Console.Write("Enter the Internal MP Unit Cost Total (branch Test Dealer): ");
      unitCostTotal = Convert.ToDecimal(Console.ReadLine());

      // prompt user for the internal mp slab list price and read the number
      Console.Write("Enter the Internal MP Slab List Price (branch Test Dealer): ");
      slabListPrice = Convert.ToDecimal(Console.ReadLine());

      //calculate Net Sheet special pricing
      specialPrice = (slabListPrice - (unitCostTotal - (netSheetPrice / locationMultiplier)));

      // display Net Sheet special pricing
      Console.WriteLine("\n\nSpecial Net Sheet Pricing is:\n\n\n {0}", Decimal.Round(specialPrice, 2));

      // insert two line breaks and tell the user how to continue or close the app
      Console.WriteLine("\n\nPress 'Enter' to continue or 'X' to close");
        } //end loop
while(Console.ReadKey(true).Key != ConsoleKey.X); // condition for the loop; it runs until the user presses the 'X' key
   } // end Main
} // end class NetSheets