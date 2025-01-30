namespace TodoAPI.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }

        TodoItem newItem = new TodoItem
        {
            Id = 1,
            Name = "Quiz 2",
            IsComplete = false

        };
    }

}
