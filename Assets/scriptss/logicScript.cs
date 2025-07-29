using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logicScript : MonoBehaviour
{
    public int PlayerScore;
    public Text Score;
    public GameObject gos;
    public GameObject strt;
    public GameObject main;
    // Start is called before the first frame update
    public void addScore()
    {
        PlayerScore++;
        Score.text=PlayerScore.ToString();
    }
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Gameover()
    {
        gos.SetActive(true);
    }
    public void sS()
    {
        strt.SetActive(false);
        main.SetActive(true);
    }
}
