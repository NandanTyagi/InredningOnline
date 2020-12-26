namespace InredningOnline.Models
{
    public class Material
    {
        public int Id;
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public string Details { get; set; }
    }
}