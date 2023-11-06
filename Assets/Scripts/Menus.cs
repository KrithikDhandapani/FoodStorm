using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    public GameObject player;
    public GameObject player2;
    private Renderer myRenderer;
    private Renderer myRenderer2;
    private Renderer myRenderer3;
    private Renderer myRenderer4;
    private Renderer myRenderer5;
    private Color myColor;
    public GameObject background;
    public GameObject Clouds;
    public Material material;
    public Material darkThemeMaterial;
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = player.GetComponent<Renderer>();
        myRenderer2 = player2.GetComponent<Renderer>();
        myRenderer3 = Clouds.GetComponentInChildren<Renderer>();
        myRenderer4 = player.GetComponent<Renderer>();
        myRenderer5 = player2.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync(0);
    }
    public void Red()
    {
        myColor = Color.red;
        myRenderer.material.color = myColor;
        myRenderer2.material.color = myColor;
    }
    public void Green()
    {
        myColor = Color.green;
        myRenderer.material.color = myColor;
        myRenderer2.material.color = myColor;
    }
    public void Blue()
    {
        myColor = Color.blue;
        myRenderer.material.color = myColor;
        myRenderer2.material.color = myColor;
    }
    public void DarkTheme()
    {
        background.GetComponent<Camera>().backgroundColor = Color.black;
        myRenderer4.material = darkThemeMaterial;
        myRenderer5.material = darkThemeMaterial;
        myRenderer3.material = material;
    }

}