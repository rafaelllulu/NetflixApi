using Flunt.Notifications;
namespace Netflix.Shared.Entities;
public abstract class Entity : Notifiable<Notification>
{
    public Entity()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; private set; }
}