using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AM
{
    public class EnenmyBulletCollision : MonoBehaviour
    {
        #region Unity API

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                _playerCurrentHP.Value--;
                Destroy(gameObject);
            }
        }

        #endregion

        #region Private

        [SerializeField]
        private IntVariable _playerCurrentHP;

        #endregion
    }
}
