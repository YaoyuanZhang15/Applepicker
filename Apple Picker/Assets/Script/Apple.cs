/***
 * Created By : Yaoyuan Zhang
 * Date Created : 1/31/2022
 * 
 * Last Edited : N/A
 * Last Edited By : N/A
 * 
 * Description Controls tree movement and apple spawning.
 * 
 */





using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    
    public static float bottomY = -20f;

    
    
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
            GameObject gm = GameObject.Find("GameManager");
            ApplePicker aScript = Camera.main.GetComponent<ApplePicker>();
            aScript.AppleDes
        }
    }
}
