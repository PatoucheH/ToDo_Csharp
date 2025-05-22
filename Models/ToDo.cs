namespace BlazorToDoApp.Models
{
   public class ToDo
    {
        public string Title { get; set; }
        public bool IsDone { get; set; } = false;
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public ToDo(string title)
        {
            Title = title;
        }
    }
}

