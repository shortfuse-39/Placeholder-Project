// ----------------------------------------------------------------------
// -------------------- 3D NPC Waypoint Guidance 
// -------------------- Thomas Cookman, UEL Games student, 2020
// ----------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DD_NPC_Patrol : MonoBehaviour
{
    //----------------------------------------------------------------------
    public enum en_states { Idle, Patrol };
    public en_states NPC_state = en_states.Idle;
    private Transform tx_target;
    private UnityEngine.AI.NavMeshAgent nm_agent;

    // ----------------------------------------------------------------------
    // Movement
    public GameObject[] GOS_waypoints;
    public float fl_speed = 3;
    public float fl_range = 15;
    private int in_next_wp = 0;

    public GameObject GO_target;
    private CharacterController CC_NPC;

    // ----------------------------------------------------------------------
    // Use this for initialization
    void Start()
    {   // Find the Game Objects we need to interact with
        CC_NPC = GetComponent<CharacterController>();
        // if no target is set find the first tagged as the enemy
        if (!GO_target)
            GO_target = GameObject.FindWithTag("Player");
    }//-----

    // ----------------------------------------------------------------------
    // Update is called once per frame
    void Update()
    {
        // SwitchStates();

        if (Vector3.Distance(transform.position, GO_target.transform.position) < fl_range)
        {
           Patrol();
        }
        else
        {
           Idle();
        }
    }//-----

   // private void SwitchStates()
   // {
   //     switch (NPC_state)
   //     {
   //         case en_states.Idle:
   //             Idle();
   //             break;
   //         case en_states.Patrol:
   //             Patrol();
   //            break;
   //     }
   // }//* 
    //-----

    // ----------------------------------------------------------------------
    void Patrol()
    {
        //Are there any waypoints defined?
        if (GOS_waypoints.Length > 0)
        {   // Look at the next WP
            transform.LookAt(GOS_waypoints[in_next_wp].transform.position);

            // Move towards the WP
            CC_NPC.SimpleMove(fl_speed * transform.TransformDirection(Vector3.forward));

            // if we get close move to WP target the next
            if (Vector3.Distance(GOS_waypoints[in_next_wp].transform.position, transform.position) < 1)
            {
                if (in_next_wp < GOS_waypoints.Length - 1)
                    in_next_wp++;
                else
                    in_next_wp = 0;
            }
        }
    }//-----

    // ----------------------------------------------------------------------
    void Idle()
    {
        if (Vector3.Distance(transform.position, tx_target.position) < fl_range)
            NPC_state = en_states.Patrol;

    }//-----

    // ----------------------------------------------------------------------


}//==========