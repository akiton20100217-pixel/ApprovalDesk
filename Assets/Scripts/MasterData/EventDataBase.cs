using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EventDataBase", menuName = "DataBase/EventDataBase")]
public class EventDataBase : ScriptableObject
{
    public List<EventData> Events = new List<EventData>();
}
