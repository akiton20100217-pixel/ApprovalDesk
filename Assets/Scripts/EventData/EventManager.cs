using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    [SerializeField] private EventDataBase _EventDataBase;

    private Dictionary<int, EventData> _EventDictionary;

    private void Awake()
    {
        for (int i = 0; i < _EventDataBase._Events.Count; i++)
        {
            _EventDataBase._Events[i]._ID = i;
        }
        
        _EventDictionary = new Dictionary<int, EventData>();
    }
}
