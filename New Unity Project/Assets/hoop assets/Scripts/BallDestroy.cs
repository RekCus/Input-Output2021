using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour
{
    public GameObject spawner;

    void OnCollisionEnter(Collision Col)
    {  

        if (Col.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
            spawner.gameObject.GetComponent<SpawnBall>().SpawnObj();
        }
    }
}
