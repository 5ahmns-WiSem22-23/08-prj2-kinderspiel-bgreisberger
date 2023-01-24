using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject roterfisch;
    public GameObject orangerfisch;
    public GameObject permagelberfisch;
    public GameObject gelberfisch;
    public GameObject boot;

    public void RotMove()
    {
        roterfisch.transform.position += new Vector3(1, 0, 0);
    }

    public void OrangeMove()
    { 
        orangerfisch.transform.position += new Vector3(1, 0, 0);
    }

    public void PermaGelbMove()
    {
        permagelberfisch.transform.position += new Vector3(1, 0, 0);
    }

    public void GelbMove()
    {
        gelberfisch.transform.position += new Vector3(1, 0, 0);
    }
}

