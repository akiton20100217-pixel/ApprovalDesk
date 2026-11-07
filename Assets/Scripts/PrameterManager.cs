using UnityEngine;

public class ParameterManager : MonoBehaviour
{
    public int electricity = 50;
    public int money = 50;
    public int satisfaction = 50;
    public int reliability = 50;

    public void ApplyPropasal(ProposalMasterData proposalData, bool isApproved)
    {
        if (isApproved)
        {
            electricity += (int)proposalData._approvalElectricity;
            money += (int)proposalData._approvalMoney;
            satisfaction += (int)proposalData._approvalSatisfaction;
            reliability += (int)proposalData._approvalReliability;
        }
        else
        {
            electricity += (int)proposalData._rejectElectricity;
            money += (int)proposalData._rejectMoney;
            satisfaction += (int)proposalData._rejectSatisfaction;
            reliability += (int)proposalData._rejectReliability;
        }

        ClampValue();

        CheckParameters();
    }

    void ClampValue()
    {
        money = Mathf.Clamp(money, 0, 100);
        electricity = Mathf.Clamp(electricity, 0, 100);
        satisfaction = Mathf.Clamp(satisfaction, 0, 100);
        reliability = Mathf.Clamp(reliability, 0, 100);
    }

    void CheckParameters()
    {
        if (money <= 0 || electricity <= 0 || satisfaction <= 0 || reliability <= 0)
        {
            // Handle game over logic here
            Debug.Log("Game Over!");
        }
    }
}
