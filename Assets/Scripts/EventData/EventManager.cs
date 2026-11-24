using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    [SerializeField] private EventDataBase _EventDataBase;

    private Dictionary<int, EventData> _EventDictionary;
    private int _nextID = 0; //初期化のとき次にIDに割り当てられる数字

    private void Awake()
    {
        _nextID = 0;
        _EventDictionary = new Dictionary<int, EventData>();

        foreach (EventData data in _EventDataBase._Events)
        {
            data._ID = _nextID;
            _nextID++;
            _EventDictionary.Add(data._ID, data);
        }
    }
}
