﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotionUsage : MonoBehaviour
{
    private Transform player;
    static public int AmountHPSmall;
    public PotionController potionController;
    public Image Potion;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Use()
    {
        Potion.gameObject.SetActive(true);
    }

    public void Close()
    {
        Potion.gameObject.SetActive(false);
    }

    public void GainHealth()
    {
        potionController.HealthGain();
    }
}