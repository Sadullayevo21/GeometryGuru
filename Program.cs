bool dasturIshlayapti = true;

do
{
    Console.Clear();
    Console.WriteLine("=== Geometry Guru ===");
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
            ArifmetikAmallar();
            break;
        case "2":
            GeometrikShakllar();
            break;
        case "3":
            TubSonlarYigindisi();
            break;
        case "4":
            dasturIshlayapti = false;
            Console.WriteLine("Dastur tugatildi. Salomat bo'ling!");
            break;
        default:
            Console.WriteLine("Noto'g'ri tanlov!");
            break;
    }

    if (dasturIshlayapti)
    {
        Console.WriteLine("\n-------------------------------------------");
        Console.WriteLine("Dasturni qayta boshlashni xohlaysizmi? (ha/yo'q)");
        string javob = Console.ReadLine().ToLower();
        if (javob == "yo'q" || javob == "yoq") dasturIshlayapti = false;
    }

} while (dasturIshlayapti);

// --- METODLAR ---

void ArifmetikAmallar()
{
    Console.WriteLine("\n--- Arifmetik va Daraja Bo'limi ---");
    Console.Write("Amalni tanlang (+, -, *, /, ^): ");
    string amal = Console.ReadLine();

    Console.Write("1-sonni kiriting: ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("2-sonni kiriting: ");
    int b = Convert.ToInt32(Console.ReadLine());

    if (amal == "^")
    {
        double natija = 1;
        for (int i = 0; i < b; i++) natija *= a;
        Console.WriteLine($"Natija: {a}^{b} = {natija}");
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
}

void GeometrikShakllar()
{
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
}

void TubSonlarYigindisi()
{
    Console.WriteLine("\n--- Tub sonlar yig'indisi ---");
    Console.Write("N sonini kiriting: ");
    int n = Convert.ToInt32(Console.ReadLine());
    long yigindi = 0;

    for (int i = 2; i <= n; i++)
    {
        bool tubmi = true;
        for (int j = 2; j * j <= i; j++)
        {
            if (i % j == 0) { tubmi = false; break; }
        }
        if (tubmi) yigindi += i;
    }
    Console.WriteLine($"1 dan {n} gacha bo'lgan tub sonlar yig'indisi: {yigindi}");
}