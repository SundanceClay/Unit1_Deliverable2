
Console.WriteLine("Hi. Welcome to our Buffet.\r\n All you can eat for $9.99!\r\n " +
    "We only charge extra for coffee. How many people are in your group? \r\n" +
    "Please, parties of 6 or lower.");
int peopleInGroup = int.Parse(Console.ReadLine());
if (peopleInGroup > 6 || peopleInGroup < 0) 
    Console.WriteLine("\r\nOh sorry, can only seat parties up to 6. Have a nice day.");
else
{
    decimal totalBill = 0;
    int numbWater = 0;
    int numbCoffee = 0;
    Console.WriteLine($"\r\nA table for {peopleInGroup}! Please follow me and take a seat. " +
        $"Let's get everyone started with some drinks. We've got water or coffee.");
    for (int i = 0; i < peopleInGroup; i++)
    {
        Console.WriteLine($"\r\nAlright, person number {i+1}, water or coffee?");
        string beverage = Console.ReadLine().ToLower();
        if (beverage != "water" && beverage != "coffee")
        {
            Console.WriteLine("We don't have that. No drink for you!");
        }
        else if (beverage == "water")
        {
            Console.WriteLine("Water, good choice!");
            numbWater++;
        }
        else
        {
            Console.WriteLine("Coffee, okay!");
            numbCoffee++;
        }
        
    }
    Console.WriteLine($"Okay, so that's {numbCoffee} coffee(s) and {numbWater} water(s). I'll be right back. " +
            "Feel free to grab your food!");
    totalBill = (decimal)peopleInGroup * 9.99M +
            (decimal)numbWater * 0M + (decimal)numbCoffee * 2.00M;
    Console.WriteLine($"Here's your bill! Total price: ${totalBill}");
}