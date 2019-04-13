using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform player;
    public Rigidbody m_Shell;                   // Prefab of the shell.
    public Transform m_FireTransform;
    private float m_CurrentLaunchForce;
    float timer;

    float AttackDistance = 30;


    void Start()
    {

        timer = 0;

        // Add + 1 to player's last known position so bullet appears to float above ground.
        Vector3 playerPos = new Vector3(player.position.x, player.position.y + 1, player.position.z);

        // Aim bullet in player's direction.
        transform.rotation = Quaternion.LookRotation(playerPos);
    }

    // Update is called once per frame
    void Update()
    {
        // Move the projectile forward towards the player's last known direction;



        if (Vector3.Distance(transform.position, player.position) < AttackDistance)
        {


            timer += Time.deltaTime;
            if (timer > 3.0f)
            {
                //Action
                Rigidbody shellInstance =
                    Instantiate(m_Shell, m_FireTransform.position, m_FireTransform.rotation) as Rigidbody;
                shellInstance.AddForce(1200 * shellInstance.transform.forward);
                timer = 0;
            }

        }


    }

}
