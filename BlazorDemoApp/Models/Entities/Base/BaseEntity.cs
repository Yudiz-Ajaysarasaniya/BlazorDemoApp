namespace BlazorDemoApp.Models.Entities.Base
{
    public class BaseEntity : BaseIdEntity
    {
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public BaseEntity()
        {
            Active = true;
            Deleted = false;
            Created = DateTime.UtcNow;
            Modified = DateTime.UtcNow;
        }
    }
}
