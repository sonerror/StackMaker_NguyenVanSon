using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    [SerializeField] Text textLivel;
    [SerializeField] private GameObject canVasFinishLivel;

    private void Start()
    {
        Oninit();
    }
    private void Oninit()
    {
        GetLivel();
        canVasFinishLivel.SetActive(false);
        Time.timeScale = 1;
    }
    public void GetLivel()
    {
        int livel = SceneManager.GetActiveScene().buildIndex;
        textLivel.text = livel.ToString();
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("reset game");
    }
   public void startGame()
    {
        SceneManager.LoadScene(1);
    }
    public void FinishLivel()
    {
        canVasFinishLivel.SetActive(true);
        Time.timeScale = 0;
    }
}
