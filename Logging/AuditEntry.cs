// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

using Common.Entities.Models.Logging;

namespace Common.Entities.I32.Logging
{
	/// <inheritdoc />
	public record AuditEntry : AuditEntry<int, int>
    {
        public AuditEntry(AuditType auditType, string text, string userId, string context, int contextId, byte[] rowVersion, string data, string differences) : base(auditType, text, userId, context, contextId, rowVersion, data, differences)
        { }
    }
}