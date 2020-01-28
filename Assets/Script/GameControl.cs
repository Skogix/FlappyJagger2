using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    // en static instans som är lätt att komma åt som en singleton
    public static GameControl instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;

    // awake är ännu tidigare än start så dubbelkolla så inga andra instanser är igång
    private void Awake()
    {
        // om det inte finns någon gamecontrol, sätt det till den här
        if (instance == null)
        {
            instance = this;
        }
        // annars förstör
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
