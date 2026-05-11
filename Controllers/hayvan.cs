namespace HayvanatBahcesiProje.Models
{
    public class Hayvan
    {
        public int Id { get; set; }
        public string Ad { get; set; } = string.Empty;
        public string Tur { get; set; } = string.Empty;
        public string Ulke { get; set; } = string.Empty;
        public string Omur { get; set; } = string.Empty;
        public string Boy { get; set; } = string.Empty;
        public string Agirlik { get; set; } = string.Empty;
        public string Bilgi { get; set; } = string.Empty;
        public string? ResimUrl { get; set; }
    }
}