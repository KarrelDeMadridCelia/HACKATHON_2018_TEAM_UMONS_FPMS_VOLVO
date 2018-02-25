using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentController : MonoBehaviour {

    
    public GameObject target;

    private UnityEngine.AI.NavMeshAgent nav;
    private Animator Anim;
    private float speed;
    //Vector2 smoothDeltaPosition = Vector2.zero;
    //Vector2 Velocity = Vector2.zero;

    // Use this for initialization
    void Start ()
    {
        nav = this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        Anim = this.gameObject.GetComponent<Animator>();
        speed = nav.speed;

    }
	
	// Update is called once per frame
	void Update ()
    {
        nav.SetDestination(target.transform.position);

      /* Vector3 worldDeltaPosition = nav.nextPosition - transform.position;

        float dx = Vector3.Dot(transform.right, worldDeltaPosition);
        float dy = Vector3.Dot(transform.forward, worldDeltaPosition);
        Vector2 deltaPosition = new Vector2(dx, dy);
        // Low-pass filter the deltaMove
        float smooth = Mathf.Min(1.0f, Time.deltaTime / 0.15f);
        smoothDeltaPosition = Vector2.Lerp(smoothDeltaPosition, deltaPosition, smooth);

        // Update velocity if delta time is safe
        if (Time.deltaTime > 1e-5f)
            Velocity = smoothDeltaPosition / Time.deltaTime;

        bool shouldMove = Velocity.magnitude > 0.5f && nav.remainingDistance > nav.radius;


        Anim.SetBool("move", shouldMove);
        Anim.SetFloat("velx", Velocity.x);
        Anim.SetFloat("vely", Velocity.y);
       // Anim.SetBool("IsWalking", true);
       */
	}
}
