using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class camera : MonoBehaviour
{
    public Transform player;
    private Player _player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);

        }
            else 
            {

            transform.position = new Vector3(0, 0, -10);
            }
    }
}

