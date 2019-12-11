using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalScaler : MonoBehaviour
{
    public float multiplier;
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {   if (player.curHealth < 1)
        {

            transform.localScale += new Vector3(multiplier, multiplier, 0) * Time.deltaTime;
        }
    }
}
