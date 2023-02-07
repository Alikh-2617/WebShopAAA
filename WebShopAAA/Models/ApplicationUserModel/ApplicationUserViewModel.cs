namespace WebShopAAA.Models.ApplicationUserModel
{
    public class ApplicationUserViewModel
    {
        public string Id { get; set; }

        public string PassWord { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string PostCode { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Phonenummer { get; set; }

        public string Modilephone { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime? ModifiedAt { get; set; }
    }
}
