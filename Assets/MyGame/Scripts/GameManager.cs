using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject fischrot;
    public GameObject fischorange;
    public GameObject fischpermagelb;
    public GameObject fischgelb;
    public GameObject boot;

    private int Würfel;

    void Start()
    {
        Würfel = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Würfeln();
        }
    }

    void Würfeln()
    {
        Würfel = Random.Range(1, 7); // Würfelwert zwischen 1 und 6

        Debug.Log("Würfel: " + Würfel);

        if (Würfel >= 1 && Würfel <= 4)
        {
            if (Würfel == 1)
            {
                fischrot.transform.position += new Vector3(1, 0, 0);
            }
            else if (Würfel == 2)
            {
                fischorange.transform.position += new Vector3(1, 0, 0);
            }
            else if (Würfel == 3)
            {
                fischpermagelb.transform.position += new Vector3(1, 0, 0);
            }
            else if (Würfel == 4)
            {
                fischgelb.transform.position += new Vector3(1, 0, 0);
            }
        }
        else if (Würfel == 5 || Würfel == 6)
        {
            boot.transform.position += new Vector3(1, 0, 0);
        }
    }


}

