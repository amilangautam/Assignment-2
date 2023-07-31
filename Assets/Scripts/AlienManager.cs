using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienManager : MonoBehaviour
{
    public GameObject Alien;
    public float value;
    public Vector3 sizeChange;

    public void moveLeft()
    {
        value = value - 0.1f;
        Alien.transform.position = new Vector3(value, 0, 0);
    }

    public void RotateLeft()
    {
        Alien.transform.Rotate(0f, 20f, 0f);
    }

    public void Grow()
    {
        Alien.transform.localScale = Alien.transform.localScale + sizeChange;
    }
    public void ResetAlien()
    {
        Alien.transform.position = new Vector3(0, 0, 0);
        Alien.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        Alien.transform.localScale = new Vector3(2, 2, 2);

    }
}
