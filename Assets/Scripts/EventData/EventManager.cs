using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class EventManager : MonoBehaviour
{
    [FormerlySerializedAs("eventDataBase")] [SerializeField] private EventDataBase _EventDataBase;

    private Dictionary<int, EventData> _EventDictionary;

    private void Awake()
    {
        _EventDictionary = new Dictionary<int, EventData>();

        foreach (EventData data in _EventDataBase._Events)
        {
            _EventDictionary.Add(data._ID, data);
        }
    }
}
