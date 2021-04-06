using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;
    public GameObject spawnLocation;

    void FixedUpdate() 
    {
        OVRInput.FixedUpdate();
    
        if(OVRInput.GetDown(OVRInput.Button.One))
        {
            SpawnObj();
        }
        
    }

    // This script will simply instantiate the Prefab when the function is called.
    public void SpawnObj()
    {
        Instantiate(myPrefab, spawnLocation.transform.position, Quaternion.identity);
    }

}
