using UnityEngine;

namespace Selena
{
    /// <summary>
    /// 發射系統基底
    /// </summary>
    public class FireSystemBase : MonoBehaviour
    #region 發射基底
    {
        [SerializeField, Header("子彈預製物")]
        private GameObject prefaBullet;
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpawn;
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpawnFirst;
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpawnSec;

        protected void SpawnBullet()
        {
            Instantiate(prefaBullet, pointSpawn.position, pointSpawn.rotation);
            Instantiate(prefaBullet, pointSpawnFirst.position, pointSpawnFirst.rotation);
            Instantiate(prefaBullet, pointSpawnSec.position, pointSpawnSec.rotation);
        }
    }
    #endregion
}
