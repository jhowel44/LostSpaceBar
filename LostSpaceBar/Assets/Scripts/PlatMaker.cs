using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatMaker : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject spawnee;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(1))
        {
            Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
        }
    }
}
