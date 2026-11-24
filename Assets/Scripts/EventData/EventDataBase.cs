using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "EventDataBase", menuName = "DataBase/EventDataBase")]
public class EventDataBase : ScriptableObject
{
    [FormerlySerializedAs("Events")] public List<EventData> _Events = new List<EventData>();
}
