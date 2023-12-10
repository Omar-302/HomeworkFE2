using Classes;

namespace Repository
{
    internal class CustomerRepository
    {
        private readonly CarShopContext context;

        public CustomerRepository(CarShopContext context)
        {
            this.context = context;
        }
        //دالة لإضافة عميل إلى قاعدة البيانات
        public void AddCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        //دالة تحديث بيانات عميل 
        public void UpdateCustomer(Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
        }

        //دالة حذف عميل
        public void DeleteCustomer(int idCustomer)
        {
            var customer = GetCustomerById(idCustomer);
            if (customer != null)
            {
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
        }

        // دالة العثور على عميل بواسطة معرّفه
        public Customer GetCustomerById(int idCustomer)
        {
            return context.Customers.Find(idCustomer);
        }

        //دالة للحصول على جميع العملاء
        public List<Customer> GetAllCustomer()
        {
            return context.Customers.ToList();
        }
    }
}
