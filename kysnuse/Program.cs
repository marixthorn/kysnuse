string obsah_textaku = File.ReadAllText("text.txt");

Console.WriteLine("---------------");

string[] zeme = obsah_textaku.Split(new[] { "\n" }, StringSplitOptions.None);
List<string> seznam_zemi = zeme.ToList();

foreach (var jedna_zeme in seznam_zemi)
{
    Console.WriteLine("--- Země ---");
    Console.WriteLine(jedna_zeme);
}
Console.WriteLine("Chcete vygenerovat nahodnou zemi :3 Y/N?");
string volba = Console.ReadLine();
if (volba == "Y")
{
 
    Random generator = new Random();
    int cislo_min;
    int cislo_max;
    Console.WriteLine("Zadej spodní hranici");
    string cislo_prvni = Console.ReadLine();  

    Console.WriteLine("Zadej horní hranici");
    string cislo_druhy = Console.ReadLine();
    cislo_min = Convert.ToInt32(cislo_prvni);
    cislo_max = Convert.ToInt32(cislo_druhy);

    int nahodna_pozice = generator.Next(cislo_min, cislo_max);
    Console.WriteLine(seznam_zemi[nahodna_pozice]);

}