using UnityEngine;
namespace AM
{
    public class BossCollision : MonoBehaviour
    {
        #region Unity API
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                _playerCurrentHP.Value--;
            }
        }
        #endregion
        private void OnTriggerEnter(Collider other)
        {
            if (_enemyCount.Value == 1 && other.gameObject.CompareTag("Bullet"))
            {
                _bossCurrentHP.Value--;
            }
        }

        #region private

        [SerializeField]
        private IntVariable _playerCurrentHP;
        [SerializeField]
        private IntVariable _bossCurrentHP;
        [SerializeField]
        private IntVariable _enemyCount;

        #endregion
    }
}
