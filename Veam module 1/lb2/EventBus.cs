using System;
using System.Collections.Generic;
namespace VeamSoftware_Labs.Veam_module_1.lb2
{
    public static class EventBus
    {
        private static readonly Dictionary<Type, Func<Object>> _mapping = new Dictionary<Type, Func<Object>>();

        private static T GetPresentationEvent<T, TArgs>()
            where T : PresentationEvent<TArgs>, new()
            where TArgs : IPresentationEventArgs
        {
            if (_mapping.ContainsKey(typeof(T)))
            {
                return _mapping[typeof(T)]() as T;
            }

            var presEvent = new T();
            _mapping.Add(typeof(T), () => presEvent);

            return presEvent;
        }

        public static void Subscribe<T, TArgs>(Action<TArgs> action) where T : PresentationEvent<TArgs>, new()
            where TArgs : IPresentationEventArgs
        {
            var presEvent = GetPresentationEvent<T, TArgs>();
            presEvent.Subscribe(action);
        }

        public static void Publish<T, TArgs>(TArgs args) where T : PresentationEvent<TArgs>, new()
            where TArgs : IPresentationEventArgs
        {
            var presEvent = GetPresentationEvent<T, TArgs>();
            presEvent.Publish(args);
        }
    }
}