using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AM
{
    public class EnemyCollision : MonoBehaviour
    {
        #region Exposed

        [SerializeField]
        private IntVariable _playerCurrentHP;
        [SerializeField]
        private IntVariable _enemyCount;
        [SerializeField]
        private float _timeBeforeDestroy;

        #endregion

        #region Unity API

        private void Start()
        {
            _death = GetComponent<AudioSource>();
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                _playerCurrentHP.Value--;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Bullet"))
            {
                _death.Play();
                Destroy(gameObject, _timeBeforeDestroy);
            }
        }

        private void OnDestroy()
        {
            _enemyCount.Value--;
        }

        #endregion

        #region Private

        private AudioSource _death;

        #endregion

    }
}
