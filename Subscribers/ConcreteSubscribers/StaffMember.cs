using _15._Behavioral_Design_Patterns.Orders;
using _15._Behavioral_Design_Patterns.Users;

namespace _15._Behavioral_Design_Patterns.Subscribers.ConcreteSubscribers
{
    public class StaffMember : BaseUser, ISubscriber
    {
        public void Notify(Order order)
        {
            Console.WriteLine($"Staff[{Id}]: The order [{order.Id}] is [{order.OrderStatus}]\n");
        }
    }
}
