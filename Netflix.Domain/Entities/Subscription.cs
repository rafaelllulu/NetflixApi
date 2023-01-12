using Netflix.Domain.Enums;
using Netflix.Shared.Entities;

namespace Netflix.Domain.Entities;

public class Subscription : Entity
{
    public Subscription()
    {
        Type = ESubscriptionType.Waiting;
    }
    public ESubscriptionType Type { get; private set; }
    public DateTime Date { get; private set; }
    public DateTime ExpiryDate { get; private set; }
    public bool isActive => Date > ExpiryDate;

    public void Pay()
    {
        // Validate Payment
        Date = DateTime.Now;
        ExpiryDate = Date.AddDays(30);
    }
    public void RenewSubscription()
    {
        if (isActive == true)
            AddNotification("Assinatura", "Não é possível renovar uma assinatura quando ela ainda esta ativa ");


        Date = DateTime.Now;
        ExpiryDate = Date.AddDays(30);
    }
    public void CancelSubscription()
    {
        if (isActive == false)
        {

        }
    }
}