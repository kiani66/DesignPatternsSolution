using Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Implementations
{
    public class NotificationIterator : IIterator<string>
    {
        private readonly NotificationCollection _collection;
        private int _currentIndex = 0;

        public NotificationIterator(NotificationCollection collection)
        {
            _collection = collection;
        }

        public bool HasNext()
        {
            return _currentIndex < _collection.GetNotifications().Count;
        }

        public string Next()
        {
            if (!HasNext())
            {
                return "No more elements.";
            }
            return _collection.GetNotifications()[_currentIndex++];
        }

        public string Current()
        {
            if (_currentIndex == 0 || _currentIndex > _collection.GetNotifications().Count)
            {
                return "No current element.";
            }
            return _collection.GetNotifications()[_currentIndex - 1];
        }
    }

}
