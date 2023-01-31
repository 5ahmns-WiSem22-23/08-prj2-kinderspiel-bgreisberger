using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject fischGruen;
    public GameObject fischLila;
    public GameObject fischOrange;
    public GameObject fischRot;
    public GameObject boot;

    private int intGruen;
    private int intLila;
    private int intOrange;
    private int intRot;
    private int intBoot;

    private int x;
    private int gefangeneFische;

    private int dice;

    private bool fischWin;
    private bool bootWin;

    bool fGruencatch;
    bool fLilacatch;
    bool fOrangecatch;
    bool fRotcatch;

    public void Start()
    {
        dice = 0;
        intGruen = 0;
        intLila = 0;
        intOrange = 0;
        intRot = 0;
        intBoot = -7;

        gefangeneFische = 0;

        x = 6;

        fischWin = false;
        bootWin = false;



        fGruencatch = false;
        fLilacatch = false;
        fOrangecatch = false;
        fRotcatch = false;

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rollDice();
        }

        // Fisch Win 
        if (intGruen >= x && intLila >= x && intOrange >= x || intGruen >= x && intOrange >= x && intRot >= x)
        {
            Debug.Log("Fische Gewinnen");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (intGruen >= x && intLila >= x && intRot >= x || intLila >= x && intOrange >= x && intRot >= x)
        {
            Debug.Log("Fische Gewinnen");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        // Unentschieden 
        if (intGruen >= x && intLila >= x || intGruen >= x && intOrange >= x || intGruen >= x && intRot >= x)
        {
            fischWin = true;
        }
        else if (intLila >= x && intGruen >= x || intLila >= x && intOrange >= x || intLila >= x && intRot >= x)
        {
            fischWin = true;
        }
        else if (intOrange >= x && intGruen >= x || intOrange >= 5 && intLila >= x || intOrange >= x && intRot >= x)
        {
            fischWin = true;
        }
        else if (intRot >= x && intGruen >= x || intRot >= x && intLila >= x || intRot >= x  && intOrange >= x)
        {
            fischWin = true;
        }

        // Boot Catch
        if (intBoot == intGruen && !fGruencatch)
        {
            Debug.Log("Grün gefangen");
            Destroy(fischGruen);
            gefangeneFische++;
            fGruencatch = true;

  
        }
        if (intBoot == intLila && !fLilacatch)
        {
            Debug.Log("Lila gefangen");
            Destroy(fischLila);
            gefangeneFische++;
            fLilacatch = true;

        }
        if (intBoot == intOrange && !fOrangecatch)
        {
            Debug.Log("Orange gefangen");
            Destroy(fischOrange);
            gefangeneFische++;
            fOrangecatch = true;

        }
        if (intBoot == intRot && !fRotcatch)
        {
            Debug.Log("Rot gefangen");
            Destroy(fischRot);
            gefangeneFische++;
            fRotcatch = true;

        }

        // Boot Win
        if (gefangeneFische == 2)
        {
            bootWin = true;
        }

        if(gefangeneFische == 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }

        if(bootWin == true && fischWin == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
    }

    public void rollDice()
    {
        dice = Random.Range(1, 7); 

        Debug.Log("Würfel: " + dice);

        if (dice >= 1 && dice <= 4)
        {

            if (dice == 1)
            {
                if (fischGruen == true)
                {
                    fischGruen.transform.position += new Vector3(1, 0, 0);
                    intGruen++;
                    Debug.Log("Grün = " + intGruen);
                }

                else if (fischOrange == false)
                {
                    boot.transform.position += new Vector3(1, 0, 0);
                    intBoot++;
                    Debug.Log("Boot = " + intBoot);
                }
            }
            else if (dice == 2)
            {
                if (fischLila == true)
                {
                    fischLila.transform.position += new Vector3(1, 0, 0);
                    intLila++;
                    Debug.Log("Lila = " + intLila);
                }
                else if (fischLila == false)
                {
                    boot.transform.position += new Vector3(1, 0, 0);
                    intBoot++;
                    Debug.Log("Boot = " + intBoot);
                }
            }
            else if (dice == 3)
            {
                if (fischOrange == true)
                {
                    fischOrange.transform.position += new Vector3(1, 0, 0);
                    intOrange++;
                    Debug.Log("Orange = " + intOrange);
                }
                else if (fischOrange == false)
                    {
                    boot.transform.position += new Vector3(1, 0, 0);
                    intBoot++;
                    Debug.Log("Boot = " + intBoot);
                }
                
            }
            else if (dice == 4)
            {
                if (fischRot == true)
                {
                    fischRot.transform.position += new Vector3(1, 0, 0);
                    intRot++;
                    Debug.Log("Rot = " + intRot);
                }
                else if (fischRot == false)
                {
                    boot.transform.position += new Vector3(1, 0, 0);
                    intBoot++;
                    Debug.Log("Boot = " + intBoot);
                }
            }
        }
        else if (dice == 5 || dice == 6)
        {
            boot.transform.position += new Vector3(1, 0, 0);
            intBoot++;
            Debug.Log("Boot = " + intBoot);
        }
    }

    

}

