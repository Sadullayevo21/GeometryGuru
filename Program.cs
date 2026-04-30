Console.WriteLine("GeometryGuru Loyihasiga Xush Kelibsiz");
Console.WriteLine("Uchburchak peremetrini hisoblash");

Console.Write("1-tomonni kiriting: ");
decimal a = Convert.ToDecimal(Console.ReadLine());
Console.Write("2-tomonni kiriting: ");
decimal b = Convert.ToDecimal(Console.ReadLine());
Console.Write("3-tomonni kiriting: ");
decimal c = Convert.ToDecimal(Console.ReadLine()); // P = a + b + c
decimal p = a + b + c;
Console.WriteLine($"Uchburchak perimetri: {p}");
