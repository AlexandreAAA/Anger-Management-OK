using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AM
{
    public class Bullet : MonoBehaviour
    {
        #region Exposed

        public Transform m_bulletTransform;
        public Rigidbody m_bulletRigidbody;
        #endregion

        #region Unity API

        private void Awake()
        {
            m_bulletTransform = GetComponent<Transform>();
            m_bulletRigidbody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            Vector3 velocity = m_bulletTransform.forward * _bulletSpeed;
            Vector3 movementStep = velocity * Time.fixedDeltaTime;
            Vector3 newPosition = m_bulletTransform.position + movementStep;
            m_bulletRigidbody.MovePosition(newPosition);
        }

        public void Shoot(float speed)
        {
            _bulletSpeed = speed;
        }

        #endregion

        #region Private

        private float _bulletSpeed;

        #endregion
    }
}