using UnityEngine;

namespace Selena
{
    /// <summary>
    /// 移動系統
    /// </summary>
    public class MoveSystem : MonoBehaviour
    {
        #region 背景物件移動速度
        [SerializeField, Header("移動速度"), Range(-10, 0)]
        private float speed = -3.5f;

        private void Update()
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        #endregion
    }
}
