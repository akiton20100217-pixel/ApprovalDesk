using UnityEngine;

[CreateAssetMenu(fileName = "ProposalMasterData", menuName = "Scriptable Objects/ProposalMasterData")]
public class ProposalMasterData : ScriptableObject
{
    [Header("*** Data Type ***")]
    [SerializeField] public string proposerName;
    [SerializeField] [TextArea] public string proposalContent;

    [Header("*** Approval Parameta ***")]
    [SerializeField] public float _approvalElectricity;
    [SerializeField] public float _approvalMoney;
    [SerializeField] public float _approvalSatisfaction;
    [SerializeField] public float _approvalReliability;

    [Header("*** Reject Parameta ***")]
    [SerializeField] public float _rejectElectricity;
    [SerializeField] public float _rejectMoney;
    [SerializeField] public float _rejectSatisfaction;
    [SerializeField] public float _rejectReliability;
}
