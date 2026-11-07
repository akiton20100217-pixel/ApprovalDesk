using UnityEngine;
using UnityEngine.UI;

public class UIParamata : MonoBehaviour
{
    [Header("*** Parameter Reference ***")]
    public ParameterManager parameterManager;

    public Scrollbar MoneyScrollbar;
    public Scrollbar ElectricityScrollbar;
    public Scrollbar SatisfactionScrollbar;
    public Scrollbar ReliabilityScrollbar;

    void Update()
    {
        MoneyScrollbar.size = parameterManager.money / 100f;
        ElectricityScrollbar.size = parameterManager.electricity / 100f;
        SatisfactionScrollbar.size = parameterManager.satisfaction / 100f;
        ReliabilityScrollbar.size = parameterManager.reliability / 100f;
    }
}
