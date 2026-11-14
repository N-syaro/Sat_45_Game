using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5.0f; // 移動速度

    void Update()
    {
        // 常に右（X軸プラス方向）へ移動させる
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }
}
