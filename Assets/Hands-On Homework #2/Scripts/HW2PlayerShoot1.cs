using UnityEngine;

public class HW2PlayerShoot : MonoBehaviour
{
    public GameObject preFab;
    public Transform bulletTrash;
    public Transform bulletSpawn;

    private const float timer = 0.5f;
    private float _currenttime = 0.5f;
    private bool _canshoot = true;

    private void Update()
    {
       Timer();
       shoot();
     
    }

    private void Timer()
    {
        if (!_canshoot)
        {
            _currenttime -= Time.deltaTime;

            if (_currentTime < 0)
            {
                _canShoot = true;
                _currentTime = timer;
            }
        }
    }

    private void shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && _canShoot)
        {
            GameObject bullet2 = Instantiate(preFab, bulletSpawn.position, Quaternion.identity);

            bullet2.transform.SetParent(bulletTrash);

            _canShoot = false;
        }
    }
}
