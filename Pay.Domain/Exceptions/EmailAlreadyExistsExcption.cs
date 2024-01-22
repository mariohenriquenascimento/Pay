namespace Pay.Domain.Exceptions
{
    public class EmailAlreadyExistsExcption : Exception
    {
        public EmailAlreadyExistsExcption(string email)
            : base($"O email informado '{email}' já está cadastrado. Tente outro.")
        {
        }
    }
}
    

