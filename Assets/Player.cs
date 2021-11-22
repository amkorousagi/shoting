using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Sprite sprite_idle;
    public Sprite sprite_left;
    public Sprite sprite_right;
    public int velocity;

    private Rigidbody2D rigidbody2D;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite_idle;
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Screen.safeArea.Contains(transform.position));
        if (Input.GetAxis("Horizontal") < 0)
        {
            spriteRenderer.sprite = sprite_left;
            rigidbody2D.AddForce(new Vector2(-1 * velocity, 0));
        }
        else if(Input.GetAxis("Horizontal") == 0)
        {
            spriteRenderer.sprite = sprite_idle;

        }
        else if(Input.GetAxis("Horizontal") > 0)
        {
            spriteRenderer.sprite = sprite_right;
            rigidbody2D.AddForce(new Vector2(1 * velocity, 0));

        }
        if (Input.GetAxis("Vertical") < 0)
        {
            rigidbody2D.AddForce(new Vector2(0,-1 * velocity));
        }
        else if (Input.GetAxis("Vertical") == 0)
        {

        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            rigidbody2D.AddForce(new Vector2(0,1 * velocity));

        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            velocity++;
        }
    }
}
