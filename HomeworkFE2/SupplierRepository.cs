using Classes;


namespace Repository
{
    public class SupplierRepository
    {
        private readonly CarShopContext context;

        public SupplierRepository(CarShopContext context)
        {
            this.context = context;
        }

        // دالة ضافة المصنّع جديد
        public void AddSupplier(Supplier supplier)
        {
            context.Suppliers.Add(supplier);
            context.SaveChanges();
        }

        // دالة تحديث بيانات مصنّع موجود
        public void UpdateSupplier(Supplier supplier)
        {
            context.Suppliers.Update(supplier);
            context.SaveChanges();
        }

        // حذف مصنّع من قاعدة البيانات
        public void DeleteSupplier(int idSupplier)
        {
            var supplier = GetSupplierById(idSupplier);
            if (supplier != null)
            {
                context.Suppliers.Remove(supplier);
                context.SaveChanges();
            }
        }

        // دالة الحصول على المصنّع بواسطة معرفه
        public Supplier GetSupplierById(int idSupplier)
        {
            return context.Suppliers.Find(idSupplier);
        }

        // دالة للحصول على قائمة بجميع المصنّعين
        public List<Supplier> GetAllSuppliers()
        {
            return context.Suppliers.ToList();
        }
    }
}
