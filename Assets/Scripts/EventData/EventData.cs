using System;
using UnityEngine;

[Serializable]
public class EventData
{
    public int _ID;

    public string _Name;

    [TextArea] public string _Discription;

    [Header("*** Approve Parameta ***")]
    public int _AppPower;
    public int _AppMoney;
    public int _AppSatisfaction;
    public int _AppTrust;

    [Header("*** Reject Parameta ***")]
    public int _RejPower;
    public int _RejMoney;
    public int _RejSatisfaction;
    public int _RejTrust;
}