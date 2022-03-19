

List<string> oldSixs = new List<string>();
foreach (string line in System.IO.File.ReadLines(@"R:\I Do Words Good\I Do Words Good\WordParser\Inputs\6Letter.csv"))
{
    oldSixs.Add(line.Replace(",", ""));
}


foreach (string line in System.IO.File.ReadLines(@"R:\I Do Words Good\I Do Words Good\WordParser\Inputs\wordle2List.txt"))
{
    string toReplace = "\", \"";
    string newLine = line.Replace(toReplace, ",");
    string[] newSixs = newLine.Split(",");

    foreach (string six in newSixs)
    {
        if (!oldSixs.Contains(six.ToLower()))
        {
            string lowerLine = six.ToLower();

            using StreamWriter file = new($@"R:\I Do Words Good\I Do Words Good\WordParser\Inputs\6Letter.csv", append: true);
            await file.WriteLineAsync(lowerLine + ",");
        }
    }
}