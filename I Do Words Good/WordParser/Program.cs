

foreach (string line in System.IO.File.ReadLines(@"R:\I Do Words Good\I Do Words Good\WordParser\Inputs\4000Words.txt"))
{
    int length = line.Length;
    if(length > 2 && length <8)
    {
        string lowerLine = line.ToLower();

        using StreamWriter file = new($@"R:\I Do Words Good\I Do Words Good\WordParser\Inputs\{length}Letter.csv", append: true);
        await file.WriteLineAsync(lowerLine +",");
    }
}
