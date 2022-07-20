using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AM
{
    public class EnemyShooter : MonoBehaviour
    {
        #region Exposed

        public Transform m_enemyShooterTransform;
        [SerializeField]
        private Transform _playerPosition;

        #endregion

        #region Unity API

        private void Awake()
        {
            m_enemyShooterTransform = GetComponent<Transform>();
        }

        private void Update()
        {
            m_enemyShooterTransform.LookAt(_playerPosition);
        }

        #endregion
    }
}
