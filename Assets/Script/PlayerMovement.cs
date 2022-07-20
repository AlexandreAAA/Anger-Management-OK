using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AM
{
    public class PlayerMovement : MonoBehaviour
    {
        #region Exposed

        public float m_playerSpeed;
        public float m_orientationHorizontal;
        public float m_orientationVertical;
        public Quaternion m_lookRotation;

        #endregion

        #region Unity API

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            MouvementVector();
            CalculateRotation();
        }

        private void FixedUpdate()
        {
            MoveandRotateRB();
        }

        #endregion

        #region Method

        private void MouvementVector()
        {
            _playerMovement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            _playerMovement.Normalize();
        }

        private void CalculateRotation()
        {
            _orientationInput = new Vector3(Input.GetAxis("Horizontal2"), 0, Input.GetAxis("Vertical2"));

            if (_orientationInput.sqrMagnitude > 0)
            {
                m_lookRotation = Quaternion.LookRotation(_orientationInput.normalized);
            }
        }

        private void MoveandRotateRB()
        {
            _rigidbody.velocity = m_playerSpeed * Time.fixedDeltaTime * _playerMovement;

            if (_orientationInput != Vector3.zero)
            {
                _rigidbody.MoveRotation(m_lookRotation.normalized);
            }
        }

        #endregion

        #region private

        private Vector3 _orientationInput;
        private Vector3 _playerMovement;
        private Rigidbody _rigidbody;

        #endregion
    }
}