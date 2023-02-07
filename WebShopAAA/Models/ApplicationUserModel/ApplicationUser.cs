using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebShopAAA.Models.Tables;

namespace WebShopAAA.Models.ApplicationUserModel
{
	public class ApplicationUser  : IdentityUser // for extending Identity user tabel
	{
		//tabel propertis for User Model
		//public string Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Address { get; set; }

		public string PostCode { get; set; }

		public string City { get; set; }

		public string Country { get; set; }

		public string Phonenummer { get; set; }

		public string Modilephone { get; set; }

		public DateTime CreateAt { get; set; }

		public DateTime? ModifiedAt{ get; set; }

	}
}