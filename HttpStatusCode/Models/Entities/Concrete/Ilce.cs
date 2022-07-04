using HttpStatusCode.Models.Entities.Abstract;

namespace HttpStatusCode.Models.Entities.Concrete
{
    public class Ilce : BaseEntity
    {
        public string IlceAdi { get; set; }
        public string SehirId { get; set; }
        public Sehir Sehir { get; set; }

    }
}