using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AM
{
    public class EnemyBullet : MonoBehaviour
    {
        #region Exposed

        public Transform m_enemyBulletTransform;
        public Rigidbody m_enemyBulletRigidbody;

        #endregion

        #region Unity API

        private void Awake()
        {
            m_enemyBulletTransform = GetComponent<Transform>();
            m_enemyBulletRigidbody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            Vector3 velocity = m_enemyBulletTransform.forward * _enemyBulletSpeed;
            Vector3 movementStep = velocity * Time.fixedDeltaTime;
            Vector3 newPosition = m_enemyBulletTransform.position + movementStep;
            m_enemyBulletRigidbody.MovePosition(newPosition);
        }

        public void Shoot(float speed)
        {
            _enemyBulletSpeed = speed;
        }

        #endregion

        #region Private

        private float _enemyBulletSpeed;

        #endregion
    }
}