using System.Collections.Generic;
using System;

public static class EventManager<IEventArgs>
{
    private static Dictionary<string, Action<IEventArgs>> eventDictionary = new Dictionary<string, Action<IEventArgs>>();

    public static void RegisterEvent(string eventType, Action<IEventArgs> eventHandler)
    {
        if (!eventDictionary.ContainsKey(eventType))
        {
            eventDictionary[eventType] = eventHandler;
        }
        else
        {
            eventDictionary[eventType] += eventHandler;
        }
    }

    public static void UnregisterEvent(string eventType, Action<IEventArgs> eventHandler)
    {
        if (eventDictionary.ContainsKey(eventType))
        {
            eventDictionary[eventType] -= eventHandler;
        }
    }

    internal static void TriggerEvent(string eventType, IEventArgs eventArgs)
    {
        if (eventDictionary.ContainsKey(eventType))
        {
            eventDictionary[eventType]?.Invoke(eventArgs);
        }
    }
}