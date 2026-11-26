using UnityEngine;

public class ParameterManager : MonoBehaviour
{
    [Header("*** Parameters ***")]
    public int _Electricity { get;　private set; } = 5;
    public int _Money { get; private set; } = 50;
    public int _Satisfaction { get; private set; } = 50;
    public int _Reliability { get; private set; } = 50;

    public void ApplyProposal(ProposalMasterData proposalData, bool isApproved)
    {
        if (isApproved)
        {
            _Electricity += (int)proposalData._ApprovalElectricity;
            _Money += (int)proposalData._ApprovalMoney;
            _Satisfaction += (int)proposalData._ApprovalSatisfaction;
            _Reliability += (int)proposalData._ApprovalReliability;
        }
        else
        {
            _Electricity += (int)proposalData._RejectElectricity;
            _Money += (int)proposalData._RejectMoney;
            _Satisfaction += (int)proposalData._RejectSatisfaction;
            _Reliability += (int)proposalData._RejectReliability;
        }

        ClampValue();

        CheckParameters();
    }

    void ClampValue()
    {
        _Money = Mathf.Clamp(_Money, 0, 100);
        _Electricity = Mathf.Clamp(_Electricity, 0, 100);
        _Satisfaction = Mathf.Clamp(_Satisfaction, 0, 100);
        _Reliability = Mathf.Clamp(_Reliability, 0, 100);
    }

    void CheckParameters()
    {
        if (_Money <= 0 || _Electricity <= 0 || _Satisfaction <= 0 || _Reliability <= 0)
        {
            // Handle game over logic here
            Debug.Log("Game Over!");
        }
    }
}
