using System;
using System.Collections.Generic;
namespace VeamSoftware_Labs.Veam_module_1.lb2
{
    public abstract class PresentationEvent<TPresentationEventArgs> where TPresentationEventArgs : IPresentationEventArgs
    {
        private readonly List<Action<TPresentationEventArgs>> _subscribers = new List<Action<TPresentationEventArgs>>();

        public void Subscribe(Action<TPresentationEventArgs> action)
        {
            _subscribers.Add(action);
        }

        public void Publish(TPresentationEventArgs message)
        {
            foreach (var sub in _subscribers)
            {
                sub.Invoke(message);
            }
        }
    }
}