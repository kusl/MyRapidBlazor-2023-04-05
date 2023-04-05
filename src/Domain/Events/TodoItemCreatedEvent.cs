using MyRapidBlazor.Domain.Common;
using MyRapidBlazor.Domain.Entities;

namespace MyRapidBlazor.Domain.Events;

public class TodoItemCreatedEvent : BaseEvent
{
    public TodoItemCreatedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}
