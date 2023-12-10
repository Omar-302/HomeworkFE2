using Classes;

namespace Repository
{
    public class PartRepository
    {
        private readonly CarShopContext context;

        public PartRepository(CarShopContext context)
        {
            this.context = context;
        }
        //دالة لإضافة قطعة إلى قاعدة البيانات
        public void AddPart(Part part)
        {
            context.Parts.Add(part);
            context.SaveChanges();
        }

        //دالة تحديث بيانات قطعة في مجموعة القطع
        public void UpdatePart(Part part)
        {
            context.Parts.Update(part); 
            context.SaveChanges();
        }

        //دالة حذف قطعة
        public void DeletePart(int idPart)
        {
            var part = GetPartById(idPart); 
            if (part != null)
            {
                context.Parts.Remove(part);
                context.SaveChanges(); 
            }
        }

        // دالة العثور على قطعة بواسطة معرّفها
        public Part GetPartById(int idPart)
        {
            return context.Parts.Find(idPart);
        }

        //دالة للحصول على جميع القطع الموجودة
        public List<Part> GetAllParts()
        {
            return context.Parts.ToList(); 
        }
    }
}
