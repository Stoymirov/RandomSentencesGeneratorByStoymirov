using System.Reflection.Metadata;
using System.Security.Cryptography;

string[] names = { "Nikola", "Gogo", "Borko", "Galin", "Dimitar", "Michael Smith", "your mother", "Kamito" };
string[] places = { "riverdale", "fame club", "your basement", "kindergarten", "school" };
string[] adverbs = { "gently", "without hesitation", "strongly", "undoubtedly", "sweetly", };
string[] verbs = { "kissed", "played with", "tried", "smelled", "licked", "took a screenshot of", "ate" };
string[] details = { "while having dinner", "while taking a nap", "while driving his tesla", "when seeing Mitako" };
string[] nouns = { "my toenail", " the Alfa romeo", "your sister", "a bucket", "the fridge", "the ice", "my cat", "the washing machine" };
string[] moreDetails = { "in the fucking world", "for god damn sake", "for the love of god", "motherfucker" };
//string[] names = { "Maika ti", "Kaka", "Golemiqt mishut", "Marti parti", "Dimitar", "Donka", "jena ti", "Stoikata" };
//string[] places = { "Doma", "maldivite", "mazeto", "kenefa", "dvora na daskaloto" };
//string[] adverbs = { "nejno", "bez da se zamisli", "vnimatelno", "smelo", "nahalno", };
//string[] verbs = { "obliza", "izqde", "pomerisa", "izpi", "narqza", "namaza s maslo", "se usmihna na" };
//string[] details = { "dokato akashe", "dokato si miehse krakata", "dokato qdeshe chorba", "kogato vidq maika ti" };
//string[] nouns = { "paleca na kucheto", " mikrata", "jena ti", "kofata s laina", "hladilnika", "televizora", "kenefa", "peralniqta" };
//string[] moreDetails = { "po dqvolite", "negovata koja mrysna", "shiban sharlatanin", "shamandur" };

while (true)
{
    if (SentenceStructureMethod() == 1)
    {
        firstTypeSentenceMethod();
        
    }
    else
    {
        secondTypeSentenceMethod();
    }

}

static int SentenceStructureMethod()
{
    Random sentenceNumber = new Random();
    int randomSentenceIndex = sentenceNumber.Next(2);

    return randomSentenceIndex;
}

void firstTypeSentenceMethod()
{
    string randomName = GetRandomWord(names);
    string randomPlaces = GetRandomWord(places);
    string randomAdverbs = GetRandomWord(adverbs);
    string randomVerbs = GetRandomWord(verbs);
    string randomDetails = GetRandomWord(details);
    string randomNoun = GetRandomWord(nouns);

    string who = $"{randomName} ot {randomPlaces}";
    string action = $"{randomAdverbs} {randomVerbs} {randomNoun}";
    string sentence = $"{who} {action} {randomDetails}";
    Console.WriteLine(sentence);
    Console.WriteLine("Click [ENTER] to generate a new one.");

    Console.ReadLine();


}

void secondTypeSentenceMethod()
{
   string randomDetail = GetRandomWord(moreDetails);
   string randomVerb = GetRandomWord(verbs);
   string randomNoun = GetRandomWord(nouns);
   string whoWithDetails = $"Koi {randomDetail} {randomVerb} {randomNoun}";
   Console.WriteLine(whoWithDetails);
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
