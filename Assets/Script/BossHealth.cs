using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AM
{
    public class BossHealth : MonoBehaviour
    {
        #region Unity API

        private void Awake()
        {
            _bossCurrentHP.Value = _bossStartHP.Value;
        }

        private void Start()
        {
            _death = GetComponent<AudioSource>();
        }

        private void Update()
        {
            if (_bossCurrentHP.Value <= 0)
            {
                _death.Play();
                Destroy(gameObject, _timeBeforeDestroy);
            }
        }

        private void OnDestroy()
        {
            _enemyCount.Value--;
        }
        #endregion

        #region Private

        [SerializeField]
        private IntVariable _bossStartHP;
        [SerializeField]
        private IntVariable _bossCurrentHP;
        [SerializeField]
        private IntVariable _enemyCount;
        private AudioSource _death;
        [SerializeField]
        private float _timeBeforeDestroy;

        #endregion
    }
}
