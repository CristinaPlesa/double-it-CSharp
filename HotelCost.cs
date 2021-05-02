using System;

class HotelCost
{
  static void Main()
  {
    Console.WriteLine("In what season are you booking a stay?");
    string season = Console.ReadLine();

    Console.WriteLine("On the weekend or a weeknight?");
    string dayOfWeek = Console.ReadLine();

    bool summer = season == "summer";
    bool weekend = dayOfWeek == "weekend";

    if (summer && weekend)
    {
      Console.WriteLine("Your stay is probably going to be pretty expensive. It's both peak travel season AND the weekend.");
    }
    else if (!(summer || weekend))
    {
      Console.WriteLine("Your stay will likely be the cheapest possible!");
    }
    else
    {
      Console.WriteLine("Your stay might be more expensive than normal!");
    }
  }
}

// NOTES for Arrays in C# Lesson 4 of 9
// > string[] fruits = { "apples", "bananas", "oranges", "grapes" };
// > fruits
// {"apples", "bananas", "oranges", "grapes"}

// > fruits[2] = "blood oranges";

// > fruits
// {"apples", "bananas", "blood oranges", "grapes"}

// > fruits[3] = "concord grapes";

// > fruits
// {"apples", "bananas", "blood oranges", "concord grapes"}


// NOTES for creating Lists Lesson 5 of 9
// > List<string> groceryList = new List<string> {};

// > groceryList
// List<string>(0) { }

// > List<string> groceryList = new List<string> {};

// > groceryList.Add("spaghetti");

// > groceryList
// List<string>(1) { "spaghetti" }

// > groceryList.Add("meatballs");

// > groceryList
// List<string>(4) { "spaghetti", "tomatoes", "basil", "meatballs" }

// > groceryList[1] = "CANDY!";

// > groceryList
// { "spaghetti", "CANDY!", "basil", "meatballs" }

// > groceryList.Remove("basil")

// > groceryList
// { "spaghetti", "CANDY!", "meatballs" }

// NOTES for dictionaries Lesson 6 of 9
// > Dictionary<string, string> myDictionary = new Dictionary<string, string>() { {"A", "apple"}, {"B", "bear"} };

// > myDictionary
// { {"A", "apple"}, {"B", "bear"} }

// > myDictionary["A"]
// "apple"

// > myDictionary["B"]
// "bear"
// using bracket notation instead of dot notation to access nested information

// > myDictionary["C"] = "cat";

// > myDictionary
// {{ "A", "apple" }, { "B", "bear" }, { "C", "cat" }}

// >  Dictionary<string, int> cupcakeOrder = new Dictionary<string, int>() { {"vanilla", 12}, {"chocolate", 24}, {"raspberry", 6}, {"caramel apple", 36} };


