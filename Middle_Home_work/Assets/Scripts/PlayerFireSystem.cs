using UnityEngine;

namespace Selena
{
    /// <summary>
    /// 玩家發射系統
    /// </summary>
    public class PlayerFireSystem : FireSystemBase
    #region 玩家攻擊
    {

        // 偵測玩家的輸入行為 : 鍵盤、滑鼠、觸控、搖桿
        private void Update()
        {
            // 如果 玩家 按下空白建 就生成子彈
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }
        }
    }
    #endregion
}
