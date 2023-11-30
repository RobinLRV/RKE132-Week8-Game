string path = @"C:\Users\robin\OneDrive\Desktop";
string fileName = "chuck.txt";
string[] lines = File.ReadAllLines(Path.Combine(path, fileName));

ShowFileContent(lines);

static void ShowFileContent(string[] filecontentarray)
{
    int i = 1;
    foreach (string line in filecontentarray)
    {
        Console.WriteLine($"{i}. {line}");
        i++;
    }
}