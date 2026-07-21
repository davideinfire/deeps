var importer =
    new CsvImporter();

var transactions =
    importer.Import();

var analyzer =
    new ExpenseAnalyzer();

analyzer.Analyze(
    transactions);

ReportPrinter.Print(
    transactions);
