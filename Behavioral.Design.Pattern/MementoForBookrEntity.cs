using Behavioral.Design.Pattern.Entity;

namespace Behavioral.Design.Pattern
{
    public class MementoForBookrEntity
    {
        private Book _customer;
        public MementoForBookrEntity(Book customer)
        {
            _customer = customer.Clone();
        }
        public Book GetCustomer()
        {
            return _customer;
        }
    }
}
