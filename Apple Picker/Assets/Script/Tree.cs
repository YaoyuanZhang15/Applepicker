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

public class Tree : MonoBehaviour
{

    public GameObject applePrefab;

    public float speed = 1f;

    public float leftAndRightEdge = 10f;

    public float chanceToChangeDirections = 0.1f;

    public float secondsBetweenAppleDrops = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f);

    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if(pos.x <-leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);

        }
            else if(pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
            
    }

    private void FixedUpdate()
    {
        if(Random.value< chanceToChangeDirections)
        {
            speed *= -1;
        }
    }



}
