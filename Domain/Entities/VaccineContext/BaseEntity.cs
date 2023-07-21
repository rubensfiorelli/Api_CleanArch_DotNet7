using Pets.Domain.Notifications;
using Pets.Domain.Validations.Contracts;

namespace Pets.Domain.Entities.VaccineContext
{
    public abstract class BaseEntity : IValidations
    {
        private List<Notification> _notifications;

        protected BaseEntity(string descricao)
        {
            Id = Guid.NewGuid();
            CreateAt = DateTime.UtcNow;
        }

        public Guid Id { get; protected set; }
        public string Descricao { get; private set; }
        public DateTime CreateAt { get; private set; }
        public IReadOnlyCollection<Notification> Notifications => _notifications;

        public void SetNotificationsList(List<Notification> notifications)
        {
            _notifications = notifications;
        }


        public virtual void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public abstract bool Validation();

    }
}
