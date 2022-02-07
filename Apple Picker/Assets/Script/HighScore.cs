/***
 * Created By : Yaoyuan Zhang
 * Date Created : 1/31/2022
 * 
 * Last Edited : N/A
 * Last Edited By : N/A
 * 
 * Description High Score manager fro Apple Picker
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HighScore : MonoBehaviour
{ 
    
    
    static public int score = 1000;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            score = PlayerPrefs.GetInt("HighCore");
        }

        PlayerPrefs.SetInt("HighScore", score);
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score:" + score;

        if(score> PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }



    }
}
