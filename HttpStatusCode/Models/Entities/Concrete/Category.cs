using HttpStatusCode.Models.Entities.Abstract;

namespace HttpStatusCode.Models.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
