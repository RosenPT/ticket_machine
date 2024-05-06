//ticket machine
Dictionary<string, double> ticketInfo = new Dictionary<string, double>() 
{
    { "Adult", 10 },
    { "Kid", 4.99 },
    { "Elderly", 3.50 }
};

Console.WriteLine("Choose a ticket:");
Console.WriteLine(chooseTicekt(ticketInfo).ToString());

Ticket chooseTicekt(Dictionary<string, double> ticketInfo)
{
    int position = 0;
    string output = "";
    foreach (var item in ticketInfo)
    {
        if (item.Key == ticketInfo.Keys.ElementAt(position))
        {
            Console.WriteLine("> " + item);
        }
        else
        {
            Console.WriteLine(item);
        }
    }
    while (true)
    {
        ConsoleKeyInfo keyInput = Console.ReadKey();
        if (keyInput.Key == ConsoleKey.DownArrow)
        {
            Console.Clear();
            Console.WriteLine("Choose a ticket:");
            position++;
            if (position > ticketInfo.Count - 1)
            {
                position = ticketInfo.Count - 1;
            }
            foreach (var item in ticketInfo)
            {
                if (item.Key == ticketInfo.Keys.ElementAt(position))
                {
                    Console.WriteLine("> " + item);
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
        }
        else if (keyInput.Key == ConsoleKey.UpArrow)
        {
            Console.Clear();
            Console.WriteLine("Choose a ticket:");
            position--;
            if (position < 0)
            {
                position = 0;
            }
            foreach (var item in ticketInfo)
            {
                if (item.Key == ticketInfo.Keys.ElementAt(position))
                {
                    Console.WriteLine("> " + item);
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
        }
        else if (keyInput.Key == ConsoleKey.Enter)
        {
            Console.Clear();
            Console.WriteLine("You chose " + ticketInfo.Keys.ElementAt(position));
            Ticket ticket = new Ticket(ticketInfo.Keys.ElementAt(position), ticketInfo.Values.ElementAt(position));
            return ticket;
        }
    }
}
class Ticket
{
    public Ticket(string typeOfThicket, double price)
    {
        TypeOfThicket = typeOfThicket;
        Price = price;
    }
    private string TypeOfThicket { get; set; }
    private double Price { get; set; }

    public override string ToString()
    {
        return $"Thank you for your purchase. Your ticket: {TypeOfThicket} - {Price}$";
    }
   
}
