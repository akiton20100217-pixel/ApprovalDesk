using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;

public class AppRejSystem : MonoBehaviour
{
    [Header("*** Approval Reject Button ***")]
    [SerializeField] private Button ApprovalButton;
    [SerializeField] private Button RejectButton;

    void Start()
    {
        //各ボタンに「離した瞬間」のイベントを登録
        RegisterPointerUpEvent(ApprovalButton, OnApprovalButtonPointerUp);
        RegisterPointerUpEvent(RejectButton, OnRejectButtonPointerUp);
    }

    //ボタンに PointerUp（離した瞬間）イベントを動的に登録する汎用メソッド
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
        // your approval logic here
    }

    private void OnRejectButtonPointerUp(BaseEventData data)
    {
        Debug.Log("Reject button pressed.");
        // your rejection logic here
    }
}