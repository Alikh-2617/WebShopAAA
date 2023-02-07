using WebShopAAA.DataDB;
using WebShopAAA.Models.Tables;
using WebShopAAA.Repository.Interface;

namespace WebShopAAA.Repository.Implementation
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public PaymentRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public int Delete(int id)
        {
            var del = _applicationDbContext.PaymentDetails.Find(id);
            if (del != null)
            {
                _applicationDbContext.PaymentDetails.Remove(del);
                return 200;
            }
            return 404;
        }

        public int Insert(PaymentDetails paymentDetails)
        {
            if(paymentDetails != null)
            {
                _applicationDbContext.PaymentDetails.Add(paymentDetails);
                return 200;
            }
            return 404;
        }

        public void Save()
        {
            _applicationDbContext.SaveChanges(); 
        }
    }
}
