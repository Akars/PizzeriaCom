using System;
using PizzeriaCom.MessageHandler;

namespace PizzeriaCom
{
    public interface IMessageBroker : IDisposable
    {
        void Publish<T>(object source, T message);
        void Subscribe<T>(Action<MessagePayload<T>> subscription);
    }
}