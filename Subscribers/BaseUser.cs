namespace _15._Behavioral_Design_Patterns.Subscribers
{
    public abstract class BaseUser
    {
        private static int globalId = 0;

        public int Id { get; } = globalId++;
    }
}
