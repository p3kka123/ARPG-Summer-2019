﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackHandler : MonoBehaviour
{
    public GameObject hitboxHolder;

    private void Start()
    {
        hitboxHolder.SetActive(false);
    }

    public void attackStart()
    {
        hitboxHolder.SetActive(true);
    }

    public void attackEnd()
    {
        hitboxHolder.SetActive(false);
    }
}