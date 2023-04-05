using MyRapidBlazor.Domain.Common;
using MyRapidBlazor.Domain.Entities;

namespace MyRapidBlazor.Domain.Events;

public class TodoItemCompletedEvent : BaseEvent
{
    public TodoItemCompletedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}
