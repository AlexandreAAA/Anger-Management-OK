using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AM
{
    public class CubeRotation : MonoBehaviour
    {
        #region Exposed

        public Vector3 m_rotateAmount;

        #endregion

        #region Unity API

        private void Update()
        {
            transform.Rotate(m_rotateAmount * Time.deltaTime);
        }

        #endregion
    }
}