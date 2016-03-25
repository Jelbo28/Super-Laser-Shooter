using UnityEngine;
using System.Collections;

public class SpaceMovement : MonoBehaviour
{
    public GameObject Background;
    Vector2 spacePosition;
    Vector2 resetPosition;
    float fallSpeed = 1f;
	
    void Update()
    {

        float yPosition = transform.position.y;
        spacePosition = new Vector2(transform.position.x, yPosition - (0.05f * fallSpeed));
        transform.position = spacePosition;
        SelfDestruct();
    }

    void SelfDestruct()
    {
        if (transform.position.y <= -7)
        {
            Background.GetComponent<BackgroundGeneration>().cloneCount--;
            Destroy(gameObject);
            //resetPosition = new Vector2(transform.position.x, 7);
            //transform.position = resetPosition;
        }
    }
}
