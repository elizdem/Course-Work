namespace ClothingShop.Data
{
    interface IUnitOfWork
    {
        IRepository Repository { get; }

        void SaveChanges();
        void SaveProviderChanges();
        void SaveSoldChanges();
    }
}