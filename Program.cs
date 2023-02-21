namespace FirstRandomSentencesGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Peter", "Michell", "Jane", "Steve", "Viktor", "Stiliyan" };
            string[] places = { "Sofia", "Plovdiv", "Varna", "Burgas", "Mezdra", "Vidin", "Ruse" };
            string[] verbs = { "eats", "holds", "sees", "plays with", "brings", "lives", "jumpes" };
            string[] nouns = { "stones", "cake", "apple", "laptop", "bikes", "books", "cars" };
            string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly", "patiently", "hard" };
            string[] details = { "near the river", "at home", "in the park", "at cinema", "at home", "at school", "in the forest" };

            while (true)
            {
                string randomName = GetRandomWord(names);
                string randomNouns = GetRandomWord(nouns);
                string randomPlace = GetRandomWord(places);
                string randomVerb = GetRandomWord(verbs);
                string randomAdverb = GetRandomWord(adverbs);
                string randomDetail = GetRandomWord(details);

                string who = $"{randomName} from {randomPlace}";
                string action = $"{randomAdverb} {randomVerb} {randomNouns}";
                string sentence = $"{who} {action} {randomDetail}.";

                Console.WriteLine("Hello, this is my first random-generated sentence: ");
                Console.WriteLine(sentence);
                Console.WriteLine("Click [Enter] to generate a new one.");
                Console.ReadLine();
            }
        }
        static string GetRandomWord(string[] words)
        {
            Random random = new Random();
            int randomIndex = random.Next(words.Length);
            string word = words[randomIndex];
            return word;
        }
    }
}