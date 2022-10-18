using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillFloor : MonoBehaviour
{
    public Transform player;
    public Transform respawn_point;

    private void OnTriggerEnter(Collider other)
    {
        // set player position to respawn position
        player.transform.position = respawn_point.transform.position;

        // set player velocity/momentum to zero -- this is to reset the player without preserving momentum (NOT PORTAL!!!)
        Vector3 velocity;
        velocity.x = 0.0f;
        velocity.y = 0.0f;
        velocity.z = 0.0f;
        player.GetComponent<Rigidbody>().velocity = Vector3.zero; // (0.0f, 0.0f, 0.0f)
    }
} 