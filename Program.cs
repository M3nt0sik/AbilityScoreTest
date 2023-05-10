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


}