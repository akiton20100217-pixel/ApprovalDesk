using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    [SerializeField] private EventDataBase eventDataBase;

    private Dictionary<int, EventData> eventDictionary;

    private void Awake()
    {
        eventDictionary = new Dictionary<int, EventData>();

        foreach (EventData data in eventDataBase.Events)
        {
            eventDictionary.Add(data._ID, data);
        }
    }
}
