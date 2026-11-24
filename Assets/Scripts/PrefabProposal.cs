using TMPro;
using UnityEngine;

public class PrefabProposal : MonoBehaviour
{
    [SerializeField] private GameObject _Nametext;
    [SerializeField] private GameObject _Discriptiontext;
    
    public GameObject _Name => _Nametext;
    public GameObject _Discription => _Discriptiontext;
}
