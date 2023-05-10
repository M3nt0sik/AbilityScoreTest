// See https://aka.ms/new-console-template for more information
using AbilityScoreTest;


Class_AbilityScoreCalculator calculator = new Class_AbilityScoreCalculator();
while (true)
{
    calculator.RollResult = ReadInt(calculator.RollResult, "Poczatkowy rzut 4d6");
    calculator.DividedBy = ReadDouble(calculator.DividedBy, "Dzielone przez");
    calculator.AddAmount = ReadInt(calculator.AddAmount, "Dodawana wartosc");
    calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
    calculator.CalculateAbilityScore();
    Console.WriteLine("Obliczone punkty umiejetnosci: " + calculator.Score);
    Console.WriteLine("Wcisnij Q by zakonczyc lub inny klawisz by kontynuowac");
    char keyChar = Console.ReadKey(true).KeyChar;
    if (keyChar == 'Q' || keyChar == 'q') return;

    ReadInt
}
///<summary>
///Wyswietla informacje  i wczytuje wartosci typu int z konsoli
/// </summary>
/// <param name="lastUsedValue"> Wartosc omyslna </param>
/// <param name="prompt"> Informacja wyswietlanaw konsoli</param>
/// <returns>Wczytana wartosc int lub domyslna 
/// (jezeli nie można przetworzyc wczytanej wartosci) </returns>
static int ReadInt(int lastUsedValue, string prompt)
{
    Console.Write(prompt + "["+ lastUsedValue+"]: ");
    bool toIf = int.TryParse(Console.ReadLine(), out int read);
    if (toIf)
    {
        Console.WriteLine("Urzycie wartosci " + read);
        return read;
        }
    else
    {
        Console.WriteLine("Urzycie wartosci domyslnej " + lastUsedValue);
        return lastUsedValue;
    }
    

}
static double ReadDouble(double lastUsedValue, string prompt)
{
    Console.Write(prompt + "[" + lastUsedValue + "]: ");
    bool toIf = double.TryParse(Console.ReadLine(), out double read);
    if (toIf)
    {
        Console.WriteLine("Urzycie wartosci " + read);
        return read;
    }
    else
    {
        Console.WriteLine("Urzycie wartosci domyslnej " + lastUsedValue);
        return lastUsedValue;
    }


}