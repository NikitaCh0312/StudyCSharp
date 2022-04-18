namespace WordsReader
{
    public class WordsCollection
    {
        private readonly StreamReader _streamReader;

        public WordsCollection(string filePath)
        {
            if (filePath == null)
                throw new ArgumentNullException(nameof(filePath));
            _streamReader = new StreamReader(filePath);
        }

        public async IAsyncEnumerable<string> GetWords()
        {
            while (true)
            {
                var line = await _streamReader.ReadLineAsync();
                if (line == null)
                    yield break;
                var words = line.Split(' ', StringSplitOptions.None);
                foreach (var word in words)
                {
                    yield return word;
                }
            }
        }
    }
}
