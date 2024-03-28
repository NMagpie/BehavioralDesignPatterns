using _15._Behavioral_Design_Patterns.Users;

namespace _15._Behavioral_Design_Patterns.Orders
{
    public class Order
    {

        private static int globalId = 0;

        public int Id { get; } = globalId++;

        private readonly HashSet<ISubscriber> _subscribers = [];

        public EOrderStatus OrderStatus { get; private set; }

        public void ChangeStatus(EOrderStatus status)
        {
            OrderStatus = status;

            foreach (ISubscriber subscriber in _subscribers)
            {
                subscriber.Notify(this);
            }
        }

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

    }
}
