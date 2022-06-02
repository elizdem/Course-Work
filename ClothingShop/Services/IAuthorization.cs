namespace ClothingShop.Services
{
    interface IAuthorization
    {
        bool Authorize(string login, string password);
    }
}