using Classes;

namespace Repository
{
    public class SaleRepository
    {
        private readonly CarShopContext context;

        public SaleRepository(CarShopContext context)
        {
            this.context = context;
        }

        //دالة إضافة عملية بيع جديدة
        public void AddSale(Sale sale)
        {
            context.Sales.Add(sale);
            context.SaveChanges();
        }

        // دالة تحديث بيانات عملية بيع 
        public void UpdateSale(Sale sale)
        {
            context.Sales.Update(sale);
            context.SaveChanges();
        }

        // دالة حذف عملية بيع
        public void DeleteSale(int idSale)
        {
            var sale = GetSaleById(idSale);
            if (sale != null)
            {
                context.Sales.Remove(sale);
                context.SaveChanges();
            }
        }

        // دالة العثور على عملية بيع بواسطة معرفها
        public Sale GetSaleById(int idSale)
        {
            return context.Sales.Find(idSale);
        }

        // دالة للحصول على قائمة بجميع عمليات البيع
        public List<Sale> GetAllSales()
        {
            return context.Sales.ToList();
        }
    }
}
