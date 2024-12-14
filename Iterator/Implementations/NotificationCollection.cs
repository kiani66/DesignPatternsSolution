using Iterator.Interfaces;


namespace Iterator.Implementations
{
    public class NotificationCollection : Interfaces.ICollection<string>
    {
        private readonly List<string> _notifications = new List<string>();

        public void Add(string notification)
        {
            _notifications.Add(notification);
        }

        public IIterator<string> CreateIterator()
        {
            return new NotificationIterator(this);
        }

        public List<string> GetNotifications()
        {
            return _notifications;
        }
    }
}
