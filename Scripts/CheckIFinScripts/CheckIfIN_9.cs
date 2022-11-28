using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfIN_9 : MonoBehaviour
{

    [SerializeField] private GameObject ball10;

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
            ball10.SetActive(true);

            ball10.transform.position = new Vector3(-110.5f, 40.33f, -21.1f);

            CameraFollow.Instance.target = ball10;

            Destroy(gameObject);

            flag.SetActive(false);


        }
        else {

            Debug.Log("GAME OVER");

        }
    }
}
