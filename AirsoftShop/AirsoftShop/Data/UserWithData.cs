namespace AirsoftShop.Data
{
    public class UserWithData
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }

        public bool IsEmailConfirmed { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsPhoneConfirmed { get; set; }

        public bool IsTwoFactorEnabled { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Address { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
    }
}
