using UnityEngine;

namespace Selena
{
    /// <summary>
    /// 敵人發射系統
    /// </summary>
    public class EnemyFireSystem : FireSystemBase
    #region 敵方攻擊
    {
        [SerializeField, Header("生成間隔"), Range(0, 3)]
        private float interval = 1.5f;

        private void Awake()
        {
            InvokeRepeating("SpawnBullet", 0, interval);
        }
    }
    #endregion
}
