using UnityEngine;
using Random = UnityEngine.Random;

public class RandomSelection : MonoBehaviour
{
    //提案書の複製前にdictionaryの_IDをランダムに取得し保存する
    [Header("*** Setting ***")]
    [SerializeField] private EventDataBase _eventDataBase;
    public int currentID {get ; private set;}
    
    public int RandomizeID()
    {
        currentID = Random.Range(0, _eventDataBase._Events.Count);
        return currentID;
    }
}
