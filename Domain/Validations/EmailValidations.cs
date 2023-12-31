﻿using Pets.Domain.Notifications;

namespace Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> EmailIsValid(string email, string message, string propertyName)
        {
            if (string.IsNullOrEmpty(email))
                AddNotification(new Notification(message, propertyName));

            return this;
        }
    }
}
