using UnityEngine;
using UnityEngine.SceneManagement;
public class Spieler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private bool verloren=false;
    
    
    // Update is called once per frame
    void Update()
    {
        if (verloren)return;
	    Rigidbody rb = GetComponent<Rigidbody>();
       rb.linearVelocity = new Vector3(Input.GetAxis("Horizontal")*5,rb.linearVelocity.y,0)*(GameManager.Instance.Level*0.1f+1);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Hinderniss collided))
        {
            Invoke(nameof(GameOver),1);
            verloren=true;
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.constraints=RigidbodyConstraints.None;
            rb.linearVelocity=new Vector3(0,5,0);
            rb.angularVelocity=new Vector3(5,5,5);
        }   
        print("aua");
    }
    void GameOver()
    {
      SceneManager.LoadScene("Verloren");  
    }
}
