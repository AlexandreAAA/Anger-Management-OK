using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AM
{
    public class BulletCollision : MonoBehaviour
    {
        #region Unity API

        private void OnTriggerEnter(Collider other)
        {
            Destroy(gameObject);
        }

        #endregion
    }
}





