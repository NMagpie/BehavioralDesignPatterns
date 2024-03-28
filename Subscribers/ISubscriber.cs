using _15._Behavioral_Design_Patterns.Orders;

namespace _15._Behavioral_Design_Patterns.Users
{
    public interface ISubscriber
    {
        public void Notify(Order order);
    }
}
