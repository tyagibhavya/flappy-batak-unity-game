using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMovement : MonoBehaviour
{
    [SerializeField]
    private float jumpForce = 5f;

    private Rigidbody2D myBody;
    private SpriteRenderer sr;
    private Animator anim;
    private string FLY_ANIMATION = "Fly";
    private string OBSTRACLE_TAG = "Obstracle";
    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        transform.position.Set(-1.5f, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        DuckFly();
        StartCoroutine(AnimateDuck());
        
    }
    private void FixedUpdate()
    {
        
    }
    IEnumerator AnimateDuck()
    {
        if (Input.GetButtonDown("Jump"))
        {
            anim.SetBool(FLY_ANIMATION, true);
            yield return new WaitForSeconds (1);
            anim.SetBool(FLY_ANIMATION, false);
        }
    }
    void DuckFly()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(OBSTRACLE_TAG))
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag(OBSTRACLE_TAG))
        {
            ScoreBoardController.instance.AddPoints();
        }
    }
}
