﻿using MyRapidBlazor.WebUI.Shared.TodoLists;

namespace MyRapidBlazor.Application.TodoLists;

public class Mapping : Profile
{
    public Mapping()
    {
        CreateMap<TodoList, TodoListDto>();
        CreateMap<TodoItem, TodoItemDto>();
    }
}
