using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    float horizontalInput;
    public float speed = 5f;
    private Vector3 target;
    public GameObject interactIcon;
    Animator animator;
    Rigidbody2D rb;
    private Vector2 moveVector = Vector2.zero;

    [SerializeField]
    float whGo;





    void Start()
    {
        target = transform.position;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
  
        if(Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;    
            target.y = transform.position.y;
            animator.SetBool("run", true);
        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);




        if (transform.position.x < target.x)
        {
            animator.SetBool("runR", true);
            animator.SetBool("run", false);

        }
        if(transform.position.x > target.x )
        {
            animator.SetBool("run", true);
        }

        if(Vector3.Distance(transform.position, target) < 0.1f)
        {
            animator.SetBool("run", false);
            animator.SetBool("runR", false);
        }

    
        

    }

    public void openInteractIcon()
    {
        interactIcon.SetActive(true);
    }
    public void closeInteractIcon()
    {
        interactIcon.SetActive(false);
    }

    private void checkInteract()
    {

    }

}
