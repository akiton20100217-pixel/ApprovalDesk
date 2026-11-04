using UnityEngine;

public class ProposalInstance : MonoBehaviour
{
    [Header("*** Proposal Instance Settings ***")]
    [SerializeField] private GameObject _ProposalPrefab;
    [SerializeField] private Transform _InstancePoint;
    [SerializeField] private float _ProposalSpeed = 1.0f;
    [SerializeField] private Canvas _Canvas; //キャンバスの参照を追加

    public bool _IsProposalActive; //提案書prefabがシーン内にあるか
    public int _ProposalCount; //ゲームクリアの判定に使う変数

    void Start()
    {
        _ProposalCount = 0;
        _IsProposalActive = false;
    }

    void Update()
    {
        //提案書がシーン内にない場合、提案書を生成する
        if (_IsProposalActive == false)
        {
            GameObject instantproposal = Instantiate(_ProposalPrefab, _InstancePoint.position, Quaternion.identity, _Canvas.transform);
            Debug.Log("Proposal instantiated.");
            _IsProposalActive = true;
        }
    }
}