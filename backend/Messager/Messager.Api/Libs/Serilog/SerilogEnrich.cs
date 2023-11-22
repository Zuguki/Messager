using Serilog.Core;
using Serilog.Events;

namespace Messager.Libs.Serilog;

public class SerilogEnrich : ILogEventEnricher
{
    public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
    {
        logEvent.AddOrUpdateProperty(propertyFactory.CreateProperty("EventId", "Messager.Api"));
        logEvent.AddOrUpdateProperty(propertyFactory.CreateProperty("User", "GoodGod"));
    }
}
