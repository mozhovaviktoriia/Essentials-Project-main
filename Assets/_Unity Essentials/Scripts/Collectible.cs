using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public float rotationSpeed;
    public GameObject onCollectEffect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(0, rotationSpeed, 0); 

    }


    private void OnTriggerEnter(Collider other)
    {
     
        if (other.CompareTag("Player")) { 
              // Destroy the collectible
       Destroy(gameObject);

       // створити екземпляр ефекту частинок 
       Instantiate(onCollectEffect, transform.position, transform.rotation);

 
}
   
    }
}
