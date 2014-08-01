using UnityEngine;
using System.Collections;

public class CSJanicontrol : MonoBehaviour
{
    Animator animator;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (guiButton.chunshenjunActive)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                animator.Play("attack");
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                animator.Play("super-attack");
            }
            if (Input.GetKeyDown(KeyCode.D) || Input.GetMouseButtonDown(1))
            {
                animator.Play("protect");
            }
        }
    }
}
