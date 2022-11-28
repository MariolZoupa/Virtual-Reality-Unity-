using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfIN_15 : MonoBehaviour
{
    public int hole;

    public GameObject flag;

    private void Start()
    {
        hole = Random.Range(1, 6);

        Debug.Log("HOLE  " + hole);

        Debug.Log("FLAG  " + Flags.Instance.FlagObjArr[hole]);

        flag = Flags.Instance.FlagObjArr[hole];

        flag.SetActive(true);


    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hole" + hole))
        {


            Debug.Log("WIN");



            flag.SetActive(false);


        }
        else
        {

            Debug.Log("GAME OVER");

        }
    }
}
