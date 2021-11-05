using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    public Animator moveAnimator;
    public AudioClip eatPellet;
    private AudioSource soundEffect;
    private float duration = 1.0f;
    private Vector2 destination;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("w"))
        {
            moveAnimator.Play("PacmanMoveUp");
            destination = new Vector2(transform.position.x, transform.position.y + 1);
            duration = 1.0f;
            transform.position = Vector2.Lerp(transform.position, destination, duration);
        }
        if (Input.GetKeyDown("s"))
        {
            moveAnimator.Play("PacmanMoveDown");
            destination = new Vector2(transform.position.x, transform.position.y - 1);
            duration = 1.0f;
            transform.position = Vector2.Lerp(transform.position, destination, duration);
        }
        if (Input.GetKeyDown("a"))
        {
            moveAnimator.Play("PacmanMoveLeft");
            destination = new Vector2(transform.position.x - 1, transform.position.y);
            duration = 1.0f;
            transform.position = Vector2.Lerp(transform.position, destination, duration);
        }
        if (Input.GetKeyDown("d"))
        {
            moveAnimator.Play("PacmanMoveRight");
            destination = new Vector2(transform.position.x + 1, transform.position.y);
            duration = 1.0f;
            transform.position = Vector2.Lerp(transform.position, destination ,duration);
        }
    }


}
