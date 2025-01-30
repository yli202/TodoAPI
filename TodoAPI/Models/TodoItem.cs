using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }

    public static class TodoData
    {
        public static List<TodoItem> Items = new List<TodoItem>
        {
            new TodoItem { Id = 1, Name = "Complete assignment", IsComplete = false },
            new TodoItem { Id = 2, Name = "Prepare for Quiz #1", IsComplete = true },
            new TodoItem { Id = 3, Name = "Study for Quiz #2", IsComplete = false }, // ✅ NEW ITEM ADDED
            new TodoItem { Id = 4, Name = "Update project report", IsComplete = false }
        };
    }
}
