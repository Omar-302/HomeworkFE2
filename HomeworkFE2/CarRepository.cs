using Classes;

namespace Repository
{
    public class CarRepository
    {
        private readonly CarShopContext context;

        public CarRepository(CarShopContext context)
        {
            this.context = context;
        }

        //دالة لإضافة سيارة إلى قاعدة البيانات
        public void AddCar(Car car)
        {
            context.Cars.Add(car); 
            context.SaveChanges();
        }

        //دالة تحديث سيارة موجودة في قاعدة البيانات
        public void UpdateCar(Car car)
        {
            context.Cars.Update(car);
            context.SaveChanges();
        }

        //دالة حذف سيارة من قاعدة البيانات
        public void DeleteCar(int idCar)
        {
            var car = GetCarById(idCar); 
            if (car != null)
            {
                context.Cars.Remove(car);
                context.SaveChanges();
            }
        }

        // دالة العثور على سيارة باستخدام المعرّف
        public Car GetCarById(int idCar)
        {
            return context.Cars.Find(idCar);
        }

        //دالة للحصول على جميع السيارات الموجودة
        public List<Car> GetAllCars()
        {
            return context.Cars.ToList();
        }
    }
}
