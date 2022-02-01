using UnityEngine;
using System.Collections;

public class Pacer : MonoBehaviour
{

    public float speed = 5.0f;
    private float zMax = 4.0f;

    private float zMin = -4.0f; //starting position
    private int direction = 1; //positive to start

    void Update()
    {
        float zNew = transform.position.z +
        direction * speed * Time.deltaTime;
        if (zNew >= zMax)
        {
            zNew = zMax;
            direction *= -1;
        }
        else if (zNew <= zMin)
        {
            zNew = zMin;
            direction *= -1;
        }
        transform.position = new Vector3(7.5f, 0.75f, zNew);
    }
}
