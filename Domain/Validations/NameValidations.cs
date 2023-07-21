using Pets.Domain.Notifications;
using Pets.Domain.ValueObjects;

namespace Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> PrimeiroNomeOK(Nome nome, short maxlength, short minlength, string message, string propertyName)
        {
            if (string.IsNullOrEmpty(nome.PrimeiroNome) || (nome.PrimeiroNome.Length < minlength) || (nome.PrimeiroNome.Length > maxlength))
                AddNotification(new Notification(message, propertyName));
            return this;
        }

        public ContractValidations<T> UltimoNomeOK(Nome nome, short maxlength, short minlength, string message, string propertyName)
        {
            if (string.IsNullOrEmpty(nome.UltimoNome) || (nome.UltimoNome.Length < minlength) || (nome.UltimoNome.Length > maxlength))
                AddNotification(new Notification(message, propertyName));
            return this;
        }

    }
}
