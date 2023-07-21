using Pets.Application.Output.Results.Contracts;
using Pets.Domain.Notifications;

namespace Pets.Application.Output.Results
{
    public class Result : IResultBase
    {
        private List<Notification> _notifications;

        public Result(int resultCode, string message, bool isOK)
        {
            ResultCode = resultCode;
            Message = message;
            IsOK = isOK;
            _notifications = new List<Notification>();
        }

        public int ResultCode { get; private set; }
        public string Message { get; private set; }
        public bool IsOK { get; private set; }
        public object Data { get; private set; }
        public IReadOnlyCollection<Notification> Notifications => _notifications;

        public void SetNotifications(List<Notification> notifications)
        {
            _notifications = notifications;
        }

        public void SetData(object data)
        {
            Data = data;
        }
    }
}
