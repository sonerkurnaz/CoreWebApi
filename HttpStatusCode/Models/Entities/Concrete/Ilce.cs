namespace HttpStatusCode.Models.Entities.Concrete
{
    public class Ilce
    {
        public int Id { get; set; }
        public string IlceAdi { get; set; }
        public int SehirId { get; set; }
        public Sehir Sehir { get; set; }

    }
}