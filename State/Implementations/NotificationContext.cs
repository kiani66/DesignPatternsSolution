using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Implementations
{
    public class NotificationContext
    {
        private INotificationState _state;

        public void SetState(INotificationState state)
        {
            _state = state;
        }

        public void Process()
        {
            _state.Handle();
        }
    }
}
