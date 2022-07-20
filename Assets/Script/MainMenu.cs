using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AM
{
    public class MainMenu : MonoBehaviour
    {
        #region Exposed

        public string m_newGameScene;
        public string m_menuScene;

        #endregion

        #region Unity API

        public void PlayGame()
        {
            SceneManager.LoadSceneAsync(m_newGameScene);
        }

        public void ReturnMenu()
        {
            SceneManager.LoadScene(m_menuScene);
        }

        public void QuitGame()
        {
            Application.Quit();
        }

        #endregion

    }
}