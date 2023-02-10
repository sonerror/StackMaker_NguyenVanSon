using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private Text textCOins;
    [SerializeField] private GameManagerment GameManagerment;
         
    static int numberLivel = 1;
    // Start is called before the first frame update
    void Start()
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
    public void OnConnectedToServer(string livel)
    {
        numberLivel++;
        livel = "Livel _ " + numberLivel;
        GameManagerment.GoToScene(livel);

    }
}
