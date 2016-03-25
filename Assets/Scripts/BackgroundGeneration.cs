using UnityEngine;
using System.Collections;

public class BackgroundGeneration : MonoBehaviour
{
    public GameObject cloneRow;
    private GameObject Background;
    public int cloneCount = 8;



    void Update()
    {
        //Transform[] childCount = gameObject.GetComponentsInChildren<Transform>();
        //CountChildren();
        Debug.Log(cloneCount);
        if (cloneCount <= 9)
        {
            Debug.Log("new clone");
            Instantiate(cloneRow, new Vector2(0, 4.75f), new Quaternion(0, 0, 0, 0));
            cloneCount++;
        }
    }

  /*
    void CountChildren()
    {
        childCount = 0;
        foreach (Transform child in transform)
        {
            childCount++;
        }
    } 
    */ 
}
