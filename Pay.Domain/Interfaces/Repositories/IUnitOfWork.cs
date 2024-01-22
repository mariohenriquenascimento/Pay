namespace Pay.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IBankRepository BankRepository { get; }
        IPaymentSlipRepository PaymentSlipRepository { get; }
        IUserRepository UserRepository { get; }
        void SaveChanges();
    }
}