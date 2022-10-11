using UnityEngine;

public class ChangeScene : MonoBehaviour
{    
    [SerializeField] private GameObject _finishScene;
    [SerializeField] private GameObject _gameObjectsScene;
    [SerializeField] private AudioSource _finishSound;

    private void Start()
    {
        Time.timeScale = 1f;
        _finishScene.SetActive(false);
        _gameObjectsScene.SetActive(true); 
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.CompareTag("NewLvl"))
        {
            _finishSound.Play();
            _finishScene.SetActive(true);
            _gameObjectsScene.SetActive(false);   
            Time.timeScale = 0f;
        }
    }
}
