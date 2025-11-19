using UnityEngine;




public class Moving : MonoBehaviour
{


    [SerializeField] float mouseSensitivityX = 100f;
    [SerializeField] float mouseSensitivityY = 100f;


    [Header("Movement Settings")]
    [SerializeField] float movespeed = 60f;
    [SerializeField] float jumpheight = 10f;
    [SerializeField] float sprintmultiplier = 2f;



    bool isGrounded = true;
    int jumpamount = 1;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float speedx = Input.GetAxis("Horizontal") * movespeed * Time.deltaTime;
        float speedz = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;

        transform.Translate(speedx, 0, speedz);



        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpheight, ForceMode.Impulse);
        }


        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            movespeed = movespeed * sprintmultiplier;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            movespeed = movespeed / sprintmultiplier;
        }


    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("Grounded");
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            Debug.Log("Not Grounded");
        }

    }

   

     
}
