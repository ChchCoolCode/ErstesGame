using UnityEngine;

public class Hinderniss : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     Invoke(nameof(DestroyDelayed),8);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().linearVelocity = new Vector3(0,0,-20)*(GameManager.Instance.Level*0.1f+1);
        
    }
    void DestroyDelayed()
    {
        Destroy(gameObject);
    }
}
