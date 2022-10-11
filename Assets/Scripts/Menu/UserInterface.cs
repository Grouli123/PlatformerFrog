using UnityEngine;
//using UnityEngine.UI;

public class UserInterface : MonoBehaviour
{    
    // [SerializeField] private Text _scoreText;
    // [SerializeField] private Text _finishScoreText;
    [SerializeField] private Health _health;
    [SerializeField] private GameObject _loseScreen;
    [SerializeField] private GameObject _gamePanel;
    //[SerializeField] private AudioSource _eatSound;

    // private int _score = 0;
    // private int _highScore = 0;
    // private int _scoreStep = 10;

    private void Start() 
    {
        // _eatSound = _eatSound.GetComponent<AudioSource>();
    }

    private void Update()
    {
        // _scoreText.text = _score.ToString();
        // _finishScoreText.text = _score.ToString();
        
        if(_health.isAlive == false)
        {
            _gamePanel.SetActive(false);
            _loseScreen.SetActive(true);
        }
    }

//     public void AppendScore()
//     {
//         this._score += _scoreStep;
//         _eatSound.Play();
//     }
}
