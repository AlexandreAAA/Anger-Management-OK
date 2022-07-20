using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AM
{
    public class EnemyShootat : MonoBehaviour
    {
        #region Exposed

        [SerializeField]
        private GameObject _enemyBulletPrefab;
        [SerializeField]
        private Transform _enemyCannon;
        [SerializeField]
        private float _enemyBulletSpeed;
        [SerializeField]
        private float _delayBetweenShots;
        [SerializeField]
        private float _destroyBulletTime;

        #endregion

        #region Unity API

        private void FireEnemyBullet()
        {
            _nextShotTime = Time.time + _delayBetweenShots;
            GameObject newEnemyBullet = Instantiate(_enemyBulletPrefab, _enemyCannon.position, _enemyCannon.rotation);
            EnemyBullet enemyBullet = newEnemyBullet.GetComponent<EnemyBullet>();
            enemyBullet.Shoot(_enemyBulletSpeed);
            Destroy(newEnemyBullet, _destroyBulletTime);
        }

        private void Awake()
        {
            _nextShotTime = Time.time;
        }

        private void Update()
        {
            if (Time.time >= _nextShotTime)
            {
                FireEnemyBullet();
            }
        }

        #endregion

        #region Private

        private float _nextShotTime;

        #endregion
    }
}
