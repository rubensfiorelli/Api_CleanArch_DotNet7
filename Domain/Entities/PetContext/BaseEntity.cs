using Pets.Domain.Notifications;
using Pets.Domain.Validations.Contracts;
using Pets.Domain.ValueObjects;

namespace Pets.Domain.Entities.PetContext
{
    public abstract class BaseEntity : IValidations
    {
        private List<Notification> _notifications;

        protected BaseEntity(Nome nome)
        {
            Id = Guid.NewGuid();
            CreateAt = DateTime.UtcNow;
            Nome = nome;
        }

        public Guid Id { get; protected set; }
        public Nome Nome { get; private set; }
        public DateTime CreateAt { get; private set; }
        public IReadOnlyCollection<Notification> Notifications => _notifications;
        protected void SetNotifications(List<Notification> notifications)
        {
            _notifications = notifications;
        }


        public abstract bool Validation();

    }
}
