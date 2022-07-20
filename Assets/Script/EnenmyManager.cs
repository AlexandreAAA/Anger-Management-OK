using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AM
{
    public class EnenmyManager : MonoBehaviour
    {
        #region Exposed

        [SerializeField]
        private IntVariable _enemyCount;

        #endregion
        #region Unity API

        private void Awake()
        {
            int enemyNumber = GameObject.FindGameObjectsWithTag("Enemy").Length;
            _enemyCount.Value = enemyNumber;
        }

        #endregion

    }
}
