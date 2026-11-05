using UnityEngine;

public class ProposalInstance : MonoBehaviour
{
    [Header("*** Proposal Instance Settings ***")]
    [SerializeField] private GameObject _ProposalPrefab;
    [SerializeField] private Transform _InstancePoint;
    //[SerializeField] private float _ProposalSpeed = 1.0f; //提案書の移動速度(演出で使用予定)
    [SerializeField] private Canvas _Canvas; //キャンバスの参照を追加

    [HideInInspector]public bool _IsProposalActive; //提案書prefabがシーン内にあるか
    [HideInInspector]public int _ProposalCount; //ゲームクリアの判定に使う変数
    [HideInInspector]public GameObject _InstantProposal;

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
            //Debug.Log("Proposal instantiated.");
            _IsProposalActive = true;
        }
        return;
    }
}