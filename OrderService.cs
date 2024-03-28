using _15._Behavioral_Design_Patterns.Orders;
using _15._Behavioral_Design_Patterns.Subscribers.ConcreteSubscribers;
using _15._Behavioral_Design_Patterns.Users;

namespace _15._Behavioral_Design_Patterns
{
    public class OrderService
    {
        private readonly Dictionary<int, Order> _orders = [];

        public void PlaceOrder(Customer customer)
        {
            var order = new Order();

            order.Subscribe(customer);

            _orders.Add(order.Id, order);

            order.ChangeStatus(EOrderStatus.Pending);
        }

        public void ChangeOrderStatus(int orderId, EOrderStatus orderStatus)
        {
            var order = _orders[orderId];

            order.ChangeStatus(orderStatus);
        }

        public void Subscribe(ISubscriber subscriber, int orderId)
        {
            var order = _orders[orderId];
            order.Subscribe(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber, int orderId)
        {
            var order = _orders[orderId];

            order.Unsubscribe(subscriber);
        }
    }
}
