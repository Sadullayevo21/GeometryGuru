bool davomEtish = true;
while (davomEtish)
    {
            Console.WriteLine("=== Geometry Guru===");
            Console.WriteLine("\nAsosiy Menyu:");
            Console.WriteLine("1. Arifmetik amallar va Daraja");
            Console.WriteLine("2. Geometrik shakllar");
            Console.WriteLine("3. Tub sonlar yig'indisi (1 dan N gacha)");
            Console.WriteLine("4. Chiqish");
            Console.Write("Tanlovni kiriting: ");

            string asosiyTanlov = Console.ReadLine();

            switch (asosiyTanlov)
            {
                case "1":
                    Console.WriteLine("\n--- Arifmetik va Daraja Bo'limi ---");
                    Console.Write("Amalni tanlang (+, -, *, /, ^ - daraja): ");
                    string amal = Console.ReadLine();

                    Console.Write("1-sonni kiriting (Asos): ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("2-sonni kiriting (Daraja ko'rsatkichi): ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    if (amal == "^")
                    {
                        double darajaNatija = 1;
                        for (int i = 0; i < b; i++)
                        {
                            darajaNatija *= a;
                        }
                        Console.WriteLine($"Natija: {a} ning {b}-darajasi = {darajaNatija}");
                    }
                    else
                    {
                        switch (amal)
                        {
                            case "+": Console.WriteLine($"Natija: {a + b}"); break;
                            case "-": Console.WriteLine($"Natija: {a - b}"); break;
                            case "*": Console.WriteLine($"Natija: {a * b}"); break;
                            case "/":
                                if (b != 0) Console.WriteLine($"Natija: {a / (double)b}");
                                else Console.WriteLine("Xato: 0 ga bo'lish mumkin emas!");
                                break;
                            default: Console.WriteLine("Bunday amal mavjud emas."); break;
                        }
                    }
                    break;

                case "2":
                    Console.WriteLine("\n--- Geometriya Bo'limi ---");
                    Console.WriteLine("a. Kvadrat yuzi\nb. Uchburchak yuzi\nc. Romb yuzi");
                    Console.Write("Tanlang: ");
                    string geoTanlov = Console.ReadLine();

                    if (geoTanlov == "a")
                    {
                        Console.Write("Tomoni: ");
                        double t = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Kvadrat yuzi: {t * t}");
                    }
                    else if (geoTanlov == "b")
                    {
                        Console.Write("Asosi: ");
                        double asosi = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Balandligi: ");
                        double h = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Uchburchak yuzi: {(asosi * h) / 2}");
                    }
                    else if (geoTanlov == "c")
                    {
                        Console.Write("Diagonal 1: ");
                        double d1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Diagonal 2: ");
                        double d2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Romb yuzi: {(d1 * d2) / 2}");
                    }
                    break;

                case "3":
                    Console.WriteLine("\n--- Tub sonlar yig'indisi ---");
                    Console.Write("N sonini kiriting: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    long tubYigindi = 0;

                    for (int i = 2; i <= n; i++)
                    {
                        bool tubSonmi = true;
                        for (int j = 2; j * j <= i; j++)
                        {
                            if (i % j == 0)
                            {
                                tubSonmi = false;
                                break;
                            }
                        }
                        if (tubSonmi) tubYigindi += i;
                    }
                    Console.WriteLine($"1 dan {n} gacha bo'lgan tub sonlar yig'indisi: {tubYigindi}");
                    break;

                case "4":
                    davomEtish = false;
                    Console.WriteLine("Dastur tugatildi. Salomat bo'ling!");
                    break;

                default:
                    Console.WriteLine("Noto'g'ri tanlov!");
                    break;
            }

            if (davomEtish)
            {
                Console.WriteLine("\nMenyuga qaytish uchun ixtiyoriy tugmani bosing...");
            }
    }