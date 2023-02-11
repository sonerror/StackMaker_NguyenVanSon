using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class UIControl : MonoBehaviour
{

    [SerializeField] private GameManagerment GameManagerment;
    // Start is called before the first frame update
    void Start()
    {
        //OnInit();
    }
    private void OnInit()
    {
        GameManagerment = gameObject.GetComponent<GameManagerment>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void startGame()
    {
        SceneManager.LoadScene(1);
    }
}
