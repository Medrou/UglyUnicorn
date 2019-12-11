using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Sprite[] HealthSprites;

    public Image HealthUI;

    private Player player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

  void Update()
    {

        HealthUI.sprite = HealthSprites[player.curHealth];

    }


}
