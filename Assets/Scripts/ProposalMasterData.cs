using UnityEngine;

[CreateAssetMenu(fileName = "ProposalMasterData", menuName = "Scriptable Objects/ProposalMasterData")]
public class ProposalMasterData : ScriptableObject
{
    [Header("*** Data Type ***")]
    [SerializeField] public string proposerName;
    [SerializeField] public string proposalContent;
    [SerializeField] public float[] ApprovalParameters;
    [SerializeField] public float[] RejectParameters;

    // データ読み取り用のプロパティ
    public string ProposerName => proposerName;
    public string ProposalContent => proposalContent;
    public float[] GetApprovalParameters() => ApprovalParameters;
    public float[] GetRejectParameters() => RejectParameters;
}
