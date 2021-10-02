using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 mousePos;
    [SerializeField] private BulletCreator bulletCreator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // マウスがクリックされたなら
        if (Input.GetMouseButtonDown(0)) {
            // マウスの座標を取得
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // オブジェクトの向きをマウスの座標に向ける
            this.transform.rotation = Quaternion.FromToRotation(Vector3.up, mousePos.normalized);
            // 弾を撃つ
            bulletCreator.Shot();
        }
    }
}
