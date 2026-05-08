Console.WriteLine("=== Geometry Guru ===");

bool davomEtish = true;

while (davomEtish)
{
    Console.WriteLine("\nAsosiy Menyu:");
    Console.WriteLine("1. Arifmetik amallar");
    Console.WriteLine("2. Geometrik shakllar");
    Console.WriteLine("3. Chiqish");
    Console.Write("Tanlovni kiriting: ");

            string asosiyTanlov = Console.ReadLine();

            switch (asosiyTanlov)
            {
                case "1":
                    Console.WriteLine("\n--- Arifmetik Bo'lim ---");
                    
                    Console.Write("Amalni tanlang (+, -, *, /): ");
                    string amal = Console.ReadLine();

                    Console.Write("1-sonni kiriting: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("2-sonni kiriting: ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    switch (amal)
                    {
                        case "+":
                            Console.WriteLine($"Natija: {a} + {b} = {a + b}");
                            break;
                        case "-":
                            Console.WriteLine($"Natija: {a} - {b} = {a - b}");
                            break;
                        case "*":
                            Console.WriteLine($"Natija: {a} * {b} = {a * b}");
                            break;
                        case "/":
                            if (b == 0)
                                Console.WriteLine("Xato: 0 ga bo'lish mumkin emas!");
                            else
                                Console.WriteLine($"Natija: {a} / {b} = {a / b}");
                            break;
                        default:
                            Console.WriteLine("Bunday amal mavjud emas.");
                            break;
                    }
                    break;

                case "2":
                    Console.WriteLine("\n--- Geometriya Bo'limi ---");
                    Console.WriteLine("a. Kvadrat yuzi");
                    Console.WriteLine("b. Uchburchak yuzi");
                    Console.WriteLine("c. Romb yuzi");
                    Console.Write("Tanlang: ");
                    string geometrikTanlov = Console.ReadLine();

                    switch (geometrikTanlov)
                    {
                        case "a":
                            Console.Write("Tomoni: ");
                            double t = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Kvadrat yuzi: {t * t}");
                            break;
                        case "b":
                            Console.Write("Asosi: ");
                            double asos = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Balandligi: ");
                            double balandlik = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Uchburchak yuzi: {(asos * balandlik) / 2}");
                            break;
                        case "c":
                            Console.Write("Diagonal 1: ");
                            double d1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Diagonal 2: ");
                            double d2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Romb yuzi: {(d1 * d2) / 2}");
                            break;
                    }
                    break;

                case "3":
                    davomEtish = false;
                    Console.WriteLine("Dastur to'xtatildi. Xayr!");
                    break;

                default:
                    Console.WriteLine("Noto'g'ri raqam kiritildi!");
                    break;
            }
        }
