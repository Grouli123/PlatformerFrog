using UnityEngine;

public class Shooter : MonoBehaviour
{
  [SerializeField] private GameObject _bullet;  
  [SerializeField] private Transform _firePoint;

  [SerializeField] private AudioSource _shootSound;

  private void Start() 
  {
    _shootSound = _shootSound.GetComponent<AudioSource>();
  }

  public void Shoot(float direction)
  {
      GameObject _currentBullet = Instantiate(_bullet, _firePoint.position, _firePoint.rotation);
      _shootSound.Play();
  }
}
