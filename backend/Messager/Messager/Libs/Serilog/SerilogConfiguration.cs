using Destructurama;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;

namespace Messager.Libs.Serilog;
public static class SerilogConfiguration
{
    public static void Connect(HostBuilderContext context, LoggerConfiguration configuration)
    {
        configuration
            .Enrich.WithThreadId()
            .Enrich.FromLogContext()
            .AuditTo.Sink<SerilogSink>()
            .Filter.With<SerilogFilter>()
            .Enrich.With<SerilogEnrich>()
            .Destructure.UsingAttributes()
            .WriteTo.Console(
                LogEventLevel.Information,
                outputTemplate:
                "{Timestamp:HH:mm:ss:ms} LEVEL: [{Level}] THREAD: |{ThreadId}| USER: |{User}| ->{EventId}<- {Message}{NewLine}{Exception}");
    }
}
