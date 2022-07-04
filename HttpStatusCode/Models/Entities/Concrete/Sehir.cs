using HttpStatusCode.Models.Entities.Abstract;

namespace HttpStatusCode.Models.Entities.Concrete
{
    public class Sehir : BaseEntity
    {
        public string SehirAdi { get; set; }
        public ICollection<Ilce> Ilce { get; set; }

    }
}
