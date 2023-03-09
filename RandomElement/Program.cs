string[] snacks = { "suschi", "pizza", "burger", "chicken wings", "takeaway" };

Random rnd= new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight we re gona eat {snacks[randomIndex]}.");