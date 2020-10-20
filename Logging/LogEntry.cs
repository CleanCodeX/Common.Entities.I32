using Common.Entities.Models.Logging;
using Microsoft.Extensions.Logging;

namespace Common.Entities.I32.Logging
{
	/// <inheritdoc />
	public sealed record LogEntry : LogEntry<int, int>
    {
        public LogEntry(LogLevel logLevel, string text, string userId) : base(logLevel, text, userId) { }

        public LogEntry(LogLevel logLevel, string text, string userId, string context, string? data) : base(logLevel, text, userId, context, data) { }

        public LogEntry(LogLevel logLevel, string text, string userId, string context, int contextId) : base(logLevel, text, userId, context, contextId) { }

        public LogEntry(LogLevel logLevel, string text, string userId, string context, int contextId, string? data = null) : base(logLevel, text, userId, context, contextId, data) { }
    }
}
