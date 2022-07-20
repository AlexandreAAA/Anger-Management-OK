using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AM
{
    public class AngryCubeCol : MonoBehaviour
    {
        #region Unity API
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("player"))
            {
                _playerCurrentHP.Value--;
            }
        }
        #endregion
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Bullet"))
            {
                _bossCurrentHP.Value--;
            }
        }

        #region private

        [SerializeField]
        private IntVariable _playerCurrentHP;
        [SerializeField]
        private IntVariable _bossCurrentHP;

        #endregion

    }
}
