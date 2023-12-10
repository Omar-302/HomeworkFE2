
namespace Classes
{
    public class Part
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int SupplierId { get; set; }

        public Supplier Supplier { get; set; } // المصنّع الخاص بالقطعة

        public List<Car> Car { get; set; } // قائمة بالعلاقة بين القطعة والسيارات التي تحتوي عليها
    }
}
