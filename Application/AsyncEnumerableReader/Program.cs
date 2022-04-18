// See https://aka.ms/new-console-template for more information

using WordsReader;


WordsCollection wordsCollection = new WordsCollection(Directory.GetCurrentDirectory() + "\\text.txt");
await foreach (var word in wordsCollection.GetWords())
{
    //тут какая-то логика по валидации, проверки, итд
    Console.WriteLine(word);
}

Console.ReadLine();
