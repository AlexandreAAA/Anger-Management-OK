using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AM
{
    public class LevelManager : MonoBehaviour
    {
        #region Exposed

        public string m_winGameScene;
        public string m_looseGameScene;

        #endregion

        #region Unity API

        private void Win()
        {
            Debug.Log("T'AS GAGNE MA GUEULE !!!!");
            SceneManager.LoadScene(m_winGameScene);
        }

        private void Loose()
        {
            Debug.Log("T'ES NUL !!!");
            SceneManager.LoadScene(m_looseGameScene);
        }

        private void Update()
        {
            if (_enemyCount.Value <= 0)
            {
                Win();
            }

            if (_playerCurrentHP.Value <= 0)
            {
                Loose();
            }
        }

        #endregion

        #region Private

        [SerializeField]
        private IntVariable _playerCurrentHP;
        [SerializeField]
        private IntVariable _enemyCount;

        #endregion
    }
}
