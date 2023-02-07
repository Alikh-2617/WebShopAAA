using WebShopAAA.Models.Tables;

namespace WebShopAAA.Repository.Interface
{
    public interface IPaymentRepository
    {
        int Insert(PaymentDetails paymentDetails);
        int Delete(int id);
        void Save();
    }
}
