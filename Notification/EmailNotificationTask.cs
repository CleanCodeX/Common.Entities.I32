using System;
using Common.Entities.Models.Notification;

namespace Common.Entities.I32.Notification
{
    /// <inheritdoc />
	public record EmailNotificationTask : EmailNotificationTask<int>
    {
        public EmailNotificationTask(string subject, string body, string recipients, DateTimeOffset dueAt) : base(subject, body, recipients, dueAt, string.Empty, default) { }

        public EmailNotificationTask(string subject, string body, string recipients, DateTimeOffset dueAt, string context, int contextId) : base(subject, body, recipients, dueAt, context, contextId) { }
    }

    /// <inheritdoc />
    public record EmailNotificationTask<TContextId> : EmailNotificationTask<TContextId, int>
        where TContextId : struct
    {
        public EmailNotificationTask(string subject, string body, string recipients, DateTimeOffset dueAt) : base(subject, body, recipients, dueAt, string.Empty, default) { }

        public EmailNotificationTask(string subject, string body, string recipients, DateTimeOffset dueAt, string context, TContextId contextId) : base(subject, body, recipients, dueAt, context, contextId) {}
    }
}
