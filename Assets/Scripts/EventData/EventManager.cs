using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    [SerializeField] private EventDataBase _EventDataBase;

    private Dictionary<int, EventData> _EventDictionary;

    private void Awake()
    {
        _EventDictionary = new Dictionary<int, EventData>();

        foreach (EventData data in _EventDataBase._Events)
        {
            data._ID = _EventDataBase._Events.Count;
            _EventDictionary.Add(data._ID, data);
        }
    }
}
