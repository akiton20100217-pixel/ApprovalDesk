using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "ProposalMasterData", menuName = "Scriptable Objects/ProposalMasterData")]
public class ProposalMasterData : ScriptableObject
{
    [FormerlySerializedAs("proposerName")]
    [Header("*** Data Type ***")]
    [SerializeField] public string _ProposerName;
    [FormerlySerializedAs("proposalContent")] [SerializeField] [TextArea] public string _ProposalContent;

    [FormerlySerializedAs("_approvalElectricity")]
    [Header("*** Approval Parameta ***")]
    [SerializeField] public float _ApprovalElectricity;
    [FormerlySerializedAs("_approvalMoney")] [SerializeField] public float _ApprovalMoney;
    [FormerlySerializedAs("_approvalSatisfaction")] [SerializeField] public float _ApprovalSatisfaction;
    [FormerlySerializedAs("_approvalReliability")] [SerializeField] public float _ApprovalReliability;

    [FormerlySerializedAs("_rejectElectricity")]
    [Header("*** Reject Parameta ***")]
    [SerializeField] public float _RejectElectricity;
    [FormerlySerializedAs("_rejectMoney")] [SerializeField] public float _RejectMoney;
    [FormerlySerializedAs("_rejectSatisfaction")] [SerializeField] public float _RejectSatisfaction;
    [FormerlySerializedAs("_rejectReliability")] [SerializeField] public float _RejectReliability;
}
