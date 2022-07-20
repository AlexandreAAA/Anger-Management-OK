using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AM
{
    public class EnemyWalker : MonoBehaviour
    {
        #region Exposed
        public Vector3 m_enemyPosition;
        public Quaternion m_enemyRotation;
        public Vector3 m_joueurPosition;
        public Rigidbody m_rigidbody;

        [SerializeField]
        private Transform _playerTransform;
        [SerializeField]
        private float _speed;
        #endregion

        #region Unity API
        private void Awake()
        {
            _enemyTransform = GetComponent<Transform>();
            m_enemyPosition = _enemyTransform.position;
            m_rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            _enemyTransform.LookAt(_playerTransform);
        }

        private void FixedUpdate()
        {
            m_rigidbody.velocity = _speed * Time.fixedDeltaTime * _enemyTransform.forward;
        }
        #endregion

        #region Private
        private Transform _enemyTransform;
        #endregion
    }
}