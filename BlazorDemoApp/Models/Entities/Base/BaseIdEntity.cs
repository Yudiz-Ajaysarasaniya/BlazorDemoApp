namespace BlazorDemoApp.Models.Entities.Base
{
    public class BaseIdEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
