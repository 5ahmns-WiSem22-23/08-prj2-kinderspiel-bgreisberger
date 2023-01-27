using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject fischgrün;
    public GameObject fischlila;
    public GameObject fischorange;
    public GameObject fischrot;
    public GameObject boot;

    private int Intgrün;
    private int Intlila;
    private int Intorange;
    private int Introt;
    private int Intboot; 

    private int Würfel;

    public void Start()
    {
        Würfel = 0;
        Intgrün = 0;
        Intlila = 0;
        Intorange = 0;
        Introt = 0;
        Intboot = 0;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Würfeln();
        }
        if (Intgrün == 6)
        {
            Debug.Log("Ende Fische");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        else if (Intlila == 6)
        {
            Debug.Log("Ende Fische");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        else if (Intorange == 6)
        {
            Debug.Log("Ende Fische");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        else if (Introt == 6)
        {
            Debug.Log("Ende Fische");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        else if (Intboot == 6)
        {
            Debug.Log("Ende Boot");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }

    public void Würfeln()
    {
        Würfel = Random.Range(1, 7); 

        Debug.Log("Würfel: " + Würfel);

        if (Würfel >= 1 && Würfel <= 4)
        {
            if (Würfel == 1)
            {
                fischgrün.transform.position += new Vector3(1, 0, 0);
                Intgrün++;
                Debug.Log(Intgrün);
            }
            else if (Würfel == 2)
            {
                fischlila.transform.position += new Vector3(1, 0, 0);
                Intlila++;
                Debug.Log(Intlila);
            }
            else if (Würfel == 3)
            {
                fischorange.transform.position += new Vector3(1, 0, 0);
                Intorange++;
                Debug.Log(Intorange);
            }
            else if (Würfel == 4)
            {
                fischrot.transform.position += new Vector3(1, 0, 0);
                Introt++;
                Debug.Log(Introt);
            }
        }
        else if (Würfel == 5 || Würfel == 6)
        {
            boot.transform.position += new Vector3(1, 0, 0);
            Intboot++;
            Debug.Log(Intboot);
        }
    }

    

}

