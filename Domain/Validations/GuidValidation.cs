using Pets.Domain.Notifications;

namespace Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> GuidIsValid(object guid, string message, string propertyName)
        {
            if (guid! is Guid)
                AddNotification(new Notification(message, propertyName));

            return this;
        }
    }
}