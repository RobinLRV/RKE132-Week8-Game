//string[] heroes = { "Potter", "Skywalker", "Croft", "Scooby" };
//string[] villains = { "Voldemort", "Vader", "Dracula", "Joker", "Thanos" };

string folderPath = @"C:\Users\Robin\OneDrive\Desktop";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));

string[] weapon = { "magic wand", "plastic fork", "banana", "sword", "stick" };

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} saves the day with a {heroWeapon}!");

string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} tries to take over the world with a {villainWeapon}!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rand = new Random();
    int randomIndex = rand.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}