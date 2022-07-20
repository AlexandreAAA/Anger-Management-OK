using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AM
{
    public class SpawnPosition : MonoBehaviour
    {
        #region Unity API

        private void SpawnEnemy()
        {
            GameObject newEnemy = Instantiate(_walkerClone, transform.position, transform.rotation);
            newEnemy.transform.LookAt(_playerPosition);
        }

        private void Awake()
        {
            _nextSpawnTime = Time.time;
        }
        private void Update()
        {
            if (_enemyCount.Value <= 5 && Time.time >= _nextSpawnTime)
            {
                _nextSpawnTime = Time.time + _delayBetweenSpawn;
                SpawnEnemy();
                _enemyCount.Value++;
            }
        }

        #endregion

        #region Private

        [SerializeField]
        private GameObject _walkerClone;
        private float _nextSpawnTime;
        [SerializeField]
        private float _delayBetweenSpawn;
        [SerializeField]
        private IntVariable _enemyCount;
        [SerializeField]
        private Transform _playerPosition;

        #endregion
    }
}