using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  
public class character : MonoBehaviour
{

  public GameObject myBoxGamePreFab;

  [Header("Movement")]
public float speed = 3f;
    // Start is called before the first frame update
   Rigidbody2D rb2d;
   
    void Start()
    {
     rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position+= new Vector3 (Input.GetAxisRaw("Horizontal"),0,0)* speed *Time.deltaTime;
        
        
        
        if(Input.GetKey(KeyCode.K))
        {
GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));
        }
    }


   void FixedUpdate() 
   {


rb2d.MovePosition(transform.position + (new Vector3(Input.GetAxisRaw("Horizontal"),0,0)* speed * Time.fixedDeltaTime));
   }

   private void OnTriggerEnter2D(Collider2D other){
    if(other.tag == "Money"){
Destroy(other.gameObject);
     } 
     }
     
     }