using Classes;

namespace Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            // إنشاء كائن من السياق
            using (var context = new CarShopContext())
            {
                context.Database.EnsureCreated();
                // إنشاء كائنات المستودعات
                var carRepository = new CarRepository(context);
                var partRepository = new PartRepository(context);
                var supplierRepository = new SupplierRepository(context);

                // إضافة المصنّع
                var supplier = new Supplier
                {
                    Name = "samer abo smra",
                    Address = "12 idled gbara"
                };

                supplierRepository.AddSupplier(supplier);

                // إضافة سيارة
                var car = new Car
                {
                    Name = "supra",
                    Year = 2020,
                    Gear = "Automatic",
                    Km = 0
                };

                carRepository.AddCar(car);

                // إضافة قطعة
                var part = new Part
                {
                    Name = "blblbl",
                    Quantity = 12,
                    Price = 300m,
                    SupplierId = 1 // نفترض أن المورد بالمعرف 1 موجود بالفعل
                };

                partRepository.AddPart(part);

                Console.WriteLine("Added successfully");
            }
        }
    }
}
