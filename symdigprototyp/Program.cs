var dictSymDigSample = new Dictionary<string, int>
    {{"-", 1}, {"┴", 2}, {"c", 3}, {"┌", 4}, {"±", 5}, {"&", 6}, {"@", 7}, {"X", 8}, {"=", 9}};
var dictKeysList = dictSymDigSample.Keys.ToList();
var rnd = new Random();
var error = 0;

void PopulateScreen(Dictionary<string, int> dictSymDigSampleParam)
{
    foreach (var entry in dictSymDigSampleParam)
    {
        Console.Write(entry.Key + " ");
    }
    Console.WriteLine();

    foreach (var entry in dictSymDigSampleParam)
    {
        Console.Write(entry.Value + " ");
    }
    Console.WriteLine();
}

while (true)
{
    PopulateScreen(dictSymDigSample);
    var rndInt = rnd.Next(0, 9);
    var symbolForExam = dictKeysList[rndInt];
    Console.WriteLine(symbolForExam);

    var input = Console.ReadKey();
    if (input.KeyChar == 'q')
    { 
        Console.Clear();
        break;
    }

    var success = int.TryParse(input.KeyChar.ToString(), out var number);
    if (!success)
    {
        error++;
        Console.Clear();
        continue;
    }

    if (dictSymDigSample[symbolForExam] != number)
        error++;

    Console.Clear();
}

Console.WriteLine();
Console.WriteLine(error);