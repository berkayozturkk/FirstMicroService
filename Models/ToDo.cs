namespace FirstMicroService.Todos.WebAPI.Models;

public class ToDo
{
    public int Id { get; set; }
    public string Work { get; set; } = default!;
}
