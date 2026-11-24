using System;
using TMPro;
using UnityEngine;

public class ProposalInstance : MonoBehaviour
{
    //提案書の複製を作成するクラス
    
    [Header("*** Proposal Instance Settings ***")]
    [SerializeField] private GameObject _ProposalPrefab;
    [SerializeField] private Transform _InstancePoint;
    [SerializeField] private Canvas _Canvas; //キャンバスの参照を追加

    [HideInInspector]public bool _IsProposalActive; //提案書prefabがシーン内にあるか
    [HideInInspector]public int _ProposalCount; //ゲームクリアの判定に使う変数
    [HideInInspector]public GameObject _InstantProposal;

    [Header("*** Proposal UI Settings ***")] //提案書の複製時の文章
    [SerializeField]private TextMeshProUGUI _NameText;
    [SerializeField]private TextMeshProUGUI _DescriptionText;

    void Start()
    {
        _ProposalCount = 0;
        _IsProposalActive = false;

        NextProposal(); //最初の提案書を生成する
    }

    public void NextProposal()
    {
        //提案書がシーン内にない場合、提案書を生成する
        if (_IsProposalActive == false)
        { 
            _InstantProposal = Instantiate(_ProposalPrefab, _InstancePoint.position, Quaternion.identity, _Canvas.transform);
            _NameText.text = _ProposalCount.ToString(); //DataBaseから引っ張ってくる予定
            _IsProposalActive = true;
        }
    }
}