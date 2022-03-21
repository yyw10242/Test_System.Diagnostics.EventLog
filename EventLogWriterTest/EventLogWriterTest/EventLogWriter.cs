using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.Versioning;

namespace EventLogWriterTest
{
    static internal class EventLogWriter
    {
        [SupportedOSPlatform("windows")]
        internal static void WriteEventLogEntry(string message)
        {
            // Create an instance of EventLog
            EventLog eventLog = new EventLog();

            // Check if the event source exists. If not create it.
            if (!EventLog.SourceExists("KorEU"))
            {
                EventLog.CreateEventSource("KorEU", "KorEU_LogForDebug");
            }

            // Set the source name for writing log entries.
            eventLog.Source = "KorEU";

            // Create an event ID to add to the event log
            int eventID = 8;

            // Write an entry to the event log.
            eventLog.WriteEntry(message,
                                EventLogEntryType.Error,
                                eventID);

            // Close the Event Log
            eventLog.Close();
        }

    }
}
