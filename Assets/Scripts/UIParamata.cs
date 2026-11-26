using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class UIParamata : MonoBehaviour
{
    [FormerlySerializedAs("parameterManager")] 
    [Header("*** Parameter Reference ***")]
    public ParameterManager _ParameterManager;

    [FormerlySerializedAs("MoneyScrollbar")] public Scrollbar _MoneyScrollbar;
    [FormerlySerializedAs("ElectricityScrollbar")] public Scrollbar _ElectricityScrollbar;
    [FormerlySerializedAs("SatisfactionScrollbar")] public Scrollbar _SatisfactionScrollbar;
    [FormerlySerializedAs("ReliabilityScrollbar")] public Scrollbar _ReliabilityScrollbar;

    void Update()
    {
        _MoneyScrollbar.size = _ParameterManager._Money / 100f;
        _ElectricityScrollbar.size = _ParameterManager._Electricity / 100f;
        _SatisfactionScrollbar.size = _ParameterManager._Satisfaction / 100f;
        _ReliabilityScrollbar.size = _ParameterManager._Reliability / 100f;
    }
}
