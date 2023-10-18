string[] names = { "Nikola", "Gogo", "Borko", "Galin", "Dimitar", "Michael Smith", "your mother" };
string[] places = { "riverdale", "fame club", "your basement", "kindergarten", "school" };
string[] adverbs = { "gently", "without hesitation", "strongly", "undoubtedly", "sweetly", };
string[] verbs = { "kissed", "played with", "tried", "smelled", "licked" };
string[] details = { "while having dinner", "while taking a nap", "while driving his tesla", "when he saw Mitako"};
string[] nouns = { "pencils", "nails", "alfa romeo", "your sister", "a bucket", "ice"};

while (true)
{
    string randomName = GetRandomWord(names);
    string randomPlaces = GetRandomWord(places);
    string randomAdverbs = GetRandomWord(adverbs);
    string randomVerbs = GetRandomWord(verbs);
    string randomDetails = GetRandomWord(details);
    string randomNoun = GetRandomWord(nouns);

    string who = $"{randomName} from {randomPlaces}";
    string action = $"{randomAdverbs} {randomVerbs} {randomNoun}";
    string sentence = $"{who} {action} {randomDetails}";
    Console.WriteLine(sentence);
    Console.WriteLine("Click [ENTER] to generate a new one.");

    Console.ReadLine();
}

static string GetRandomWord(string[] words)
{
    Random random = new Random();
    int randomIndex = random.Next(words.Length);
    string word = words[randomIndex];
    return word;
}