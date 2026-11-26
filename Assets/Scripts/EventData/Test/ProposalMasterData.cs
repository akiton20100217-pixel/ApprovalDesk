using UnityEngine;

[CreateAssetMenu(fileName = "ProposalMasterData", menuName = "Scriptable Objects/ProposalMasterData")]
public class ProposalMasterData : ScriptableObject
{
    [Header("*** Data Type ***")]
    [SerializeField] public string _ProposerName;

    [SerializeField] [TextArea] public string _ProposalContent;
    
    [Header("*** Approval Parameta ***")]
    [SerializeField] public float _ApprovalElectricity;
    [SerializeField] public float _ApprovalMoney;
    [SerializeField] public float _ApprovalSatisfaction;
    [SerializeField] public float _ApprovalReliability;


    [Header("*** Reject Parameta ***")]
    [SerializeField] public float _RejectElectricity;
    [SerializeField] public float _RejectMoney;
    [SerializeField] public float _RejectSatisfaction;
    [SerializeField] public float _RejectReliability;
}
