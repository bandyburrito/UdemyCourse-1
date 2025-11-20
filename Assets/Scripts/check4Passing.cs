using UnityEngine;


public class check4Passing : MonoBehaviour
{

    private Color colorOrig;
    private Color colorTrans;
    private Renderer r;
    
    void Start()
    {
        r = GetComponent<Renderer>();
        colorOrig = r.material.color;
        colorTrans = new Color(colorOrig.r, colorOrig.g, colorOrig.b, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Passed the Point turn TRANSPARENT NOW!!!");
            r.material.color = colorTrans;
        }
    }
    
    
}
