using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;

public class ApprovalRejectSystem : MonoBehaviour
{
    [Header("*** Approval Reject Button ***")]
    [SerializeField] private Button _ApprovalButton;
    [SerializeField] private Button _RejectButton;

    [Header("*** Proposal Instance Reference ***")]
    public ProposalInstance _ProposalInstance;

    [Header("*** Parameter Manager Reference ***")]
    public ProposalMasterData _ProposalData;
    public ParameterManager _ParameterManager;
    void Start()
    {
        //各ボタンに「離した瞬間」のイベントを登録
        RegisterPointerUpEvent(_ApprovalButton, OnApprovalButtonPointerUp);
        RegisterPointerUpEvent(_RejectButton, OnRejectButtonPointerUp);
    }

    //ボタンに PointerUp（離した瞬間）イベントを登録する汎用メソッド
    private void RegisterPointerUpEvent(Button button, UnityAction<BaseEventData> action)
    {
        if (button == null) 
            return;

        // ボタンのオブジェクトに EventTrigger がなければ追加、あれば取得
        EventTrigger trigger = button.gameObject.GetComponent<EventTrigger>();
        if (trigger == null)
        {
            trigger = button.gameObject.AddComponent<EventTrigger>();
        }

        // PointerUp（離した瞬間）のエントリーを作成
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerUp;
        entry.callback.AddListener(action);

        // トリガーに登録
        trigger.triggers.Add(entry);
    }

    // 各ボタンを「離した瞬間」に呼ばれるメソッド

    private void OnApprovalButtonPointerUp(BaseEventData data)
    {
        PushButton();
        _ParameterManager.ApplyPropasal(_ProposalData, true); //承認ボタンが押されたときのパラメータ変動処理
    }

    private void OnRejectButtonPointerUp(BaseEventData data)
    {
        PushButton();
        _ParameterManager.ApplyPropasal(_ProposalData, false); //拒否ボタンが押されたときのパラメータ変動処理
    }

    private void PushButton() //ボタンが押されたときの処理
    {
        //ボタンが押された(呼ばれた)→提案書カウント++→提案書を破棄する→ゲームクリア判定→(ゲームクリアではないなら)次の提案書を生成する

        _ProposalInstance._ProposalCount++; //提案書カウント++
        Destroy(_ProposalInstance._InstantProposal); //提案書を破棄する
        //Debug.Log("Proposal destroyed.");

        _ProposalInstance._IsProposalActive = false; //提案書がシーン内にない状態にする

        //ゲームクリア判定
        if (_ProposalInstance._ProposalCount >= 5) //5はクリアに必要な提案書数なので後々、変数で管理
        {
            Debug.Log("Game Clear!");
            //ゲームクリアの演出処理をここに追加
        }
        else
        {
            //演出処理が終了するまで待つ処理をここに追加する
            _ProposalInstance.NextProposal(); //次の提案書を生成する
        }
    }
}