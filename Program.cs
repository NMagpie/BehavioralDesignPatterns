using _15._Behavioral_Design_Patterns;
using _15._Behavioral_Design_Patterns.Orders;
using _15._Behavioral_Design_Patterns.Subscribers.ConcreteSubscribers;

List<Customer> customers = [new(), new(), new(), new()];
List<StaffMember> staffMembers = [new(), new(), new()];

OrderService orderService = new();

// customers place orders

foreach (Customer customer in customers)
    orderService.PlaceOrder(customer);

// Staff Members receive orderId from notification and subscribe to it

orderService.Subscribe(staffMembers[2], 0);

orderService.Subscribe(staffMembers[1], 1);

orderService.Subscribe(staffMembers[0], 2);

// Workers preparing orders

orderService.ChangeOrderStatus(0, EOrderStatus.Created);

orderService.ChangeOrderStatus(1, EOrderStatus.Created);

orderService.ChangeOrderStatus(2, EOrderStatus.Created);

// Someone can unsubscribe from order

orderService.Unsubscribe(customers[0], 0);

// And changing status again

orderService.ChangeOrderStatus(0, EOrderStatus.Ready);

orderService.ChangeOrderStatus(1, EOrderStatus.Ready);

orderService.ChangeOrderStatus(2, EOrderStatus.Ready);