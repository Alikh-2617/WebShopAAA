namespace WebShopAAA.Models.ApplicationUsersModel
{
    public class UserModel
    {
        // table propertis for User Model

        public string  Id  { get; set; }  

        public string  UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PostCode { get; set; }

        public string Country { get; set; }

        public string TellphoneNumber { get; set; }

        public string Mobile { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime ModifiedAt { get; set; }

        public DateTime DeletedeAt { get; set; }

    }
}
