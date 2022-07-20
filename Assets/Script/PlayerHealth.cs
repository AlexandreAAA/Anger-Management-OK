using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AM
{
    public class PlayerHealth : MonoBehaviour
    {
        #region Unity API

        private void Awake()
        {
            _playerCurrentHP.Value = _playerStartHP.Value;
        }

        private void Update()
        {
            if (_playerCurrentHP.Value <= 0)
            {
                Destroy(gameObject);
            }
        }
        #endregion

        #region Private

        [SerializeField]
        private IntVariable _playerStartHP;
        [SerializeField]
        private IntVariable _playerCurrentHP;

        #endregion
    }
}