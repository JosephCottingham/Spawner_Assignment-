using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public GameObject ammoPrefab;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject ammo;

            Transform trans = transform.Find("Body").Find("FireSpawnPoint");

            Vector3 pos = trans.position;
            Quaternion rotation = trans.rotation;

            ammo = Instantiate(ammoPrefab, pos, rotation);

            ammo.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(-1000f,300f,0));
        }
    }
}
