using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flags : MonoBehaviour
{
    [SerializeField] private GameObject Flag1;
    [SerializeField] private GameObject Flag2;
    [SerializeField] private GameObject Flag3;
    [SerializeField] private GameObject Flag4;
    [SerializeField] private GameObject Flag5;
    [SerializeField] private GameObject Flag6;

    public GameObject[] FlagObjArr = new GameObject[7];


    public static Flags Instance;

    void Awake()
    {
        Instance = this;

        FlagObjArr[1] = Flag1;
        FlagObjArr[2] = Flag2;
        FlagObjArr[3] = Flag3;
        FlagObjArr[4] = Flag4;
        FlagObjArr[5] = Flag5;
        FlagObjArr[6] = Flag6;

        

    }
}
