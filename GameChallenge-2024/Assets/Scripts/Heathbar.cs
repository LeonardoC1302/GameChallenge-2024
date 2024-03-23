using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Heathbar : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private Image totalhealth;
    [SerializeField] private Image currenthealth;
    void Start()
    {
        totalhealth.fillAmount = health.getCurrentHealth() / 10;
    }

    // Update is called once per frame
    void Update()
    {
        currenthealth.fillAmount = health.getCurrentHealth() / 10;
    }
}
