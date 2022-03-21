using System.Diagnostics;

string testString = "";
while (testString != "Exit")
{
    testString = Console.ReadLine() ?? "";
    EventLogWriterTest.EventLogWriter.WriteEventLogEntry(testString);
}