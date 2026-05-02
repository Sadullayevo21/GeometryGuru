 Console.WriteLine("GeometryGuru ga xush kelibsiz");

 Console.WriteLine("Bu dasturda siz ikki xil amalni bajarishingiz mumkin: ");

Console.WriteLine("Asosiy Menyu:");
Console.WriteLine("1. Arifmetik amallar");
Console.WriteLine("2. Geometrik shakllar (Kvadrat, Uchburchak, Romb)");
Console.WriteLine("3. Chiqish");
Console.Write("Tanlovni kiriting: ");
                
string asosiyTanlov = Console.ReadLine();

if (asosiyTanlov == "1")
{
    Console.WriteLine("Arifmetik amallar menyusi");
    Console.WriteLine("1. Qo'shish (+)");
    Console.WriteLine("2. Ayirish (-)");
    Console.WriteLine("3. Ko'paytirish (*)");
    Console.WriteLine("4. Bo'lish (/)");
    Console.Write("Amalni tanlang: ");
    
    string arifmetikTanlov = Console.ReadLine();

    Console.Write("Birinchi sonni kiriting: ");
    double son1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ikkinchi sonni kiriting: ");
    double son2 = Convert.ToDouble(Console.ReadLine());

    switch (arifmetikTanlov)
    {
        case "1":
            Console.WriteLine($"Natija: {son1} + {son2} = {son1 + son2}");
            break;
        case "2":
            Console.WriteLine($"Natija: {son1} - {son2} = {son1 - son2}");
            break;
        case "3":
            Console.WriteLine($"Natija: {son1} * {son2} = {son1 * son2}");
            break;
        case "4":
            if (son2 != 0)
                Console.WriteLine($"Natija: {son1} / {son2} = {son1 / son2}");
            else
                Console.WriteLine("Xatolik: Sonni nolga bo'lish mumkin emas!");
            break;
        default:
            Console.WriteLine("Noto'g'ri tanlov kiritildi.");
            break;
    }
}
else if (asosiyTanlov == "2")
{
    Console.WriteLine("Geometrik shakllar bo'limi hali tayyor emas...");
}
else if (asosiyTanlov == "3")
{
    Console.WriteLine("Dasturdan chiqilmoqda. Xayr!");
}
else
{
    Console.WriteLine("Noto'g'ri buyruq!");
}