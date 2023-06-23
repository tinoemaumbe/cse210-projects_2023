public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine($"{entry._date}: {entry._prompt} - {entry._response}");
        }
    }

    public void SaveToFile(string fileName)
    {
        using (var writer = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date},{entry._prompt},{entry._response}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        using (var reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                var date = DateTime.Parse(values[0]);
                var prompt = values[1];
                var response = values[2];
                var entry = new Entry(prompt, response) { _date = date };
                _entries.Add(entry);
            }
        }
    }
}
