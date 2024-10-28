using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerenciadordeniveis : MonoBehaviour
{
    public static gerenciadordeniveis main;

    public Transform startPoint;
    public Transform[] path;
    private void Awake()
    {
        main = this;
    }
}
