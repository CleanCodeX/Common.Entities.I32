using System;
using Common.Entities.Models.Notification;

namespace Common.Entities.I32.Notification
{
	public record ViewNotificationTask : ViewNotificationTask<int>
    {
        public ViewNotificationTask(string text, DateTimeOffset dueAt) : base(text, dueAt, null!, default) { }
        public ViewNotificationTask(string text, DateTimeOffset dueAt, string userId) : base(text, dueAt, null!, default, userId) { }

        public ViewNotificationTask(string text, DateTimeOffset dueAt, DateTimeOffset displayBeginAt) : base(text, dueAt,
            displayBeginAt, string.Empty, default)
        { }
        public ViewNotificationTask(string text, DateTimeOffset dueAt, DateTimeOffset displayBeginAt, string userId) : base(text, dueAt, displayBeginAt, string.Empty, default, userId)
        { }

        public ViewNotificationTask(string text, DateTimeOffset dueAt, string context, int contextId) : base(text, dueAt,
            default, context, contextId)
        { }
        public ViewNotificationTask(string text, DateTimeOffset dueAt, string context, int contextId, string userId) : base(text, dueAt, default, context, contextId, userId)
        { }

        public ViewNotificationTask(string text, DateTimeOffset dueAt, DateTimeOffset displayBeginAt, string context, int contextId) : base(text, displayBeginAt, dueAt, context, contextId) { }
        public ViewNotificationTask(string text, DateTimeOffset dueAt, DateTimeOffset displayBeginAt, string context, int contextId, string userId) : base(text, displayBeginAt, dueAt, context, contextId, userId) { }
    }

    public record ViewNotificationTask<TContextId> : ViewNotificationTask<TContextId, int>
        where TContextId : struct
    {
        public ViewNotificationTask(string text, DateTimeOffset dueAt) : base(text, dueAt, null!, default) { }
        public ViewNotificationTask(string text, DateTimeOffset dueAt, string userId) : base(text, dueAt, null!, default, userId) { }

        public ViewNotificationTask(string text, DateTimeOffset dueAt, DateTimeOffset displayBeginAt) : base(text, dueAt,
            displayBeginAt, string.Empty, default)
        { }
        public ViewNotificationTask(string text, DateTimeOffset dueAt, DateTimeOffset displayBeginAt, string userId) : base(text, dueAt, displayBeginAt, string.Empty, default, userId)
        { }

        public ViewNotificationTask(string text, DateTimeOffset dueAt, string context, TContextId contextId) : base(text, dueAt,
            default, context, contextId)
        { }
        public ViewNotificationTask(string text, DateTimeOffset dueAt, string context, TContextId contextId, string userId) : base(text, dueAt, default, context, contextId, userId)
        { }

        public ViewNotificationTask(string text, DateTimeOffset dueAt, DateTimeOffset displayBeginAt, string context, TContextId contextId) : base(text, displayBeginAt, dueAt, context, contextId) {}
        public ViewNotificationTask(string text, DateTimeOffset dueAt, DateTimeOffset displayBeginAt, string context, TContextId contextId, string userId) : base(text, displayBeginAt, dueAt, context, contextId, userId) {}
    }
}
