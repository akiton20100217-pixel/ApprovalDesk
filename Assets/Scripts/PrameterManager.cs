using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ParameterManager : MonoBehaviour
{
    [SerializeField] private Scrollbar[] _parameters; // スライダーの配列

    private bool AnyParameterEmpty = false;

    // パラメータの変動値を取得するscriptable objectの参照

    private void Start()
    {
        //パラメータの初期値を設定するメソッド
        for (int i = 0; i < _parameters.Length; i++)
        {
            _parameters[i].value = 0.5f;
        }
    }

    private void Update()
    {
        if (AnyParameterEmpty = _parameters.Any(parameter => parameter.value == 0))//スライダーの値が0のものがあるかチェック
        {
            Debug.Log("GameOver");
            // ゲームオーバー処理をここに追加
        }
    }

    
}
