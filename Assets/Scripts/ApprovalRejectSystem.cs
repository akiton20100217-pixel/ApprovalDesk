using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;

public class ApprovalRejectSystem : MonoBehaviour
{
    [Header("*** Approval Reject Button ***")]
    [SerializeField] private Button ApprovalButton;
    [SerializeField] private Button RejectButton;

    public ProposalInstance proposalInstance; // ProposalInstanceスクリプトの参照を追加

    void Start()
    {
        //各ボタンに「離した瞬間」のイベントを登録
        RegisterPointerUpEvent(ApprovalButton, OnApprovalButtonPointerUp);
        RegisterPointerUpEvent(RejectButton, OnRejectButtonPointerUp);
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
        Debug.Log("Approval button pressed.");

        proposalInstance._ProposalCount++;
        if (proposalInstance._ProposalCount >= 5) //←この5は後々、変数で管理するように変更する予定
        {
            Debug.Log("Game Clear!");
            // ゲームクリアの処理をここに追加
        }
    }

    private void OnRejectButtonPointerUp(BaseEventData data)
    {
        Debug.Log("Reject button pressed.");

        proposalInstance._ProposalCount++;
        if (proposalInstance._ProposalCount >= 5)
        {
            Debug.Log("Game Clear!");
            // ゲームクリアの処理をここに追加
        }
    }
}