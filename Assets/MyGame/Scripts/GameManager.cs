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

    private int x;

    private int Würfel;

    public void Start()
    {
        Würfel = 0;
        Intgrün = 0;
        Intlila = 0;
        Intorange = 0;
        Introt = 0;
        Intboot = -5;

        x = 8;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Würfeln();
        }

        // Fisch win
        if (Intgrün >= x && Intlila >= x || Intgrün >= x && Intorange >= x || Intgrün >= x && Introt >= x)
        {
            Debug.Log("Ende Fische");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (Intlila >= x && Intgrün >= x || Intlila >= x && Intorange >= x || Intlila >= x && Introt >= x)
        {
            Debug.Log("Ende Fische");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (Intorange >= x && Intgrün >= x || Intorange >= 5 && Intlila >= x || Intorange >= x && Introt >= x)
        {
            Debug.Log("Ende Fische");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (Introt >= x && Intgrün >= x || Introt >= x && Intlila >= x || Introt >= x  && Intorange >= x)
        {
            Debug.Log("Ende Fische");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        // Boot Catch
        if (Intboot == Intgrün )
        {
            Debug.Log("Grün gefangen");
            Destroy(fischgrün);
        }
        if (Intboot == Intlila)
        {
            Debug.Log("Lila gefangen");
            Destroy(fischlila);
        }
        if (Intboot == Intorange)
        {
            Debug.Log("Orange gefangen");
            Destroy(fischorange);
        }
        if (Intboot == Introt)
        {
            Debug.Log("Rot gefangen");
            Destroy(fischrot);
        }

        // Boot Win
        if(fischgrün ==false && fischlila == false || fischgrün == false && fischorange == false || fischgrün == false && fischrot == false)
        {
            Debug.Log("Boot Gewinnt");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        if (fischlila == false && fischgrün == false || fischlila == false && fischorange == false || fischlila == false && fischrot == false)
        {
            Debug.Log("Boot Gewinnt");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        if (fischorange == false && fischgrün == false || fischorange == false && fischlila == false || fischorange == false && fischrot == false)
        {
            Debug.Log("Boot Gewinnt");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        if (fischrot == false && fischgrün == false || fischrot == false && fischlila == false || fischrot == false && fischorange == false)
        {
            Debug.Log("Boot Gewinnt");
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
                if (fischgrün == true)
                {
                    fischgrün.transform.position += new Vector3(1, 0, 0);
                    Intgrün++;
                    Debug.Log("Grün = " + Intgrün);
                }

                else if (fischorange == false)
                {
                    boot.transform.position += new Vector3(1, 0, 0);
                    Intboot++;
                    Debug.Log("Boot = " + Intboot);
                }
            }
            else if (Würfel == 2)
            {
                if (fischlila == true)
                {
                    fischlila.transform.position += new Vector3(1, 0, 0);
                    Intlila++;
                    Debug.Log("Lila = " + Intlila);
                }
                else if (fischlila == false)
                {
                    boot.transform.position += new Vector3(1, 0, 0);
                    Intboot++;
                    Debug.Log("Boot = " + Intboot);
                }
            }
            else if (Würfel == 3)
            {
                if (fischorange == true)
                {
                    fischorange.transform.position += new Vector3(1, 0, 0);
                    Intorange++;
                    Debug.Log("Orange = " + Intorange);
                }
                else if (fischorange == false)
                    {
                    boot.transform.position += new Vector3(1, 0, 0);
                    Intboot++;
                    Debug.Log("Boot = " + Intboot);
                }
                
            }
            else if (Würfel == 4)
            {
                if (fischrot == true)
                {
                    fischrot.transform.position += new Vector3(1, 0, 0);
                    Introt++;
                    Debug.Log("Rot = " + Introt);
                }
                else if (fischrot == false)
                {
                    boot.transform.position += new Vector3(1, 0, 0);
                    Intboot++;
                    Debug.Log("Boot = " + Intboot);
                }
            }
        }
        else if (Würfel == 5 || Würfel == 6)
        {
            boot.transform.position += new Vector3(1, 0, 0);
            Intboot++;
            Debug.Log("Boot = " + Intboot);
        }
    }

    

}

