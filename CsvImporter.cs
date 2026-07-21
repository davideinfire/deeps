using System.Collections.Generic;

public class CsvImporter
{
    public List<Transaction> Import()
    {
        return SampleStatement.Load();
    }
}
