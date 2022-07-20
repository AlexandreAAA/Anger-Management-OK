using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AM
{
    public class PlayerShoot : MonoBehaviour
    {
        #region Exposed

        [SerializeField]
        private GameObject _bulletPrefab;
        [SerializeField]
        private Transform _cannon;
        [SerializeField]
        private float _bulletSpeed;
        [SerializeField]
        private float _delayBetweenShots;
        [SerializeField]
        private float _destroyBulletTime;

        #endregion

        #region Unity API

        private void FireBullet()
        {
            _nextShotTime = Time.time + _delayBetweenShots;
            GameObject newBullet = Instantiate(_bulletPrefab, _cannon.position, _cannon.rotation);
            Bullet bullet = newBullet.GetComponent<Bullet>();
            bullet.Shoot(_bulletSpeed);
            Destroy(newBullet, _destroyBulletTime);
            _fire.Play();
        }

        private void Awake()
        {
            _nextShotTime = Time.time;
        }

        private void Start()
        {
            _fire = GetComponent<AudioSource>();
        }
        private void Update()
        {
            if (Input.GetButton("Feu") && Time.time >= _nextShotTime)
            {
                FireBullet();
            }
        }

        #endregion

        #region Private

        private float _nextShotTime;
        private AudioSource _fire;

        #endregion
    }
}
