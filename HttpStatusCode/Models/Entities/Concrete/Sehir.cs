namespace HttpStatusCode.Models.Entities.Concrete
{
    public class Sehir
    {
        public int Id { get; set; }
        public string SehirAdi { get; set; }
        public ICollection<Ilce> Ilce { get; set; }

    }
}
