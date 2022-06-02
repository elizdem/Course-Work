namespace ClothingShop.Entities
{
    class Provider : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public long TelNumber { get; set; }
        public string Email { get; set; }
    }
}
