public class DataAccess
{
    private string _connectionString;

    public DataAccess(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<Scripture> GetAllScriptures()
    {
        List<Scripture> scriptures = new List<Scripture>();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Scriptures", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string text = reader.GetString(1);
                string book = reader.GetString(2);
                int chapter = reader.GetInt32(3);
                int startVerse = reader.GetInt32(4);
                int endVerse = reader.GetInt32(5);
                Reference reference = new Reference(book, chapter, startVerse, endVerse);
                Scripture scripture = new Scripture(text, reference);
                scriptures.Add(scripture);
            }
            reader.Close();
        }
        return scriptures;
    }

    public void AddScripture(Scripture scripture)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Scriptures (Text, Book, Chapter, StartVerse, EndVerse) VALUES (@Text, @Book, @Chapter, @StartVerse, @EndVerse)", connection);
            command.Parameters.AddWithValue("@Text", scripture.GetRenderedText("visible"));
            command.Parameters.AddWithValue("@Book", scripture.Reference.Book);
            command.Parameters.AddWithValue("@Chapter", scripture.Reference.Chapter);
            command.Parameters.AddWithValue("@StartVerse", scripture.Reference.StartVerse);
            command.Parameters.AddWithValue("@EndVerse", scripture.Reference.EndVerse);
            command.ExecuteNonQuery();
        }
    }
}