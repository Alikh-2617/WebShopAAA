using System.ComponentModel.DataAnnotations;
using WebShopAAA.Models.ApplicationUserModel;
using WebShopAAA.Models.Concetant;
using WebShopAAA.Models.Tables;

namespace WebShopAAA.Models.ViewModels
{
    public class OrderDetails_ViewModel
    {

        public ApplicationUser? UserId { get; set; }

        public int Total { get; set; }

        public int PaymentId { get; set; }

        public PaymentDetails? Payment { get; set; }

        public bool IsPicked { get; set; }

    }
}
