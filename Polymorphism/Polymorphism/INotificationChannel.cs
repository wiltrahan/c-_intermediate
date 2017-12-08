using System.Security.Cryptography;

namespace Polymorphism
{
    public interface INotificationChannel
    {
        void Send(Message message);
    }
}