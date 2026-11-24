using System.Collections;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] private float spawndelay=2;
    [SerializeField] private GameObject[] Hindernisse;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      InvokeRepeating(nameof(Herstellen),1,2);
    }

    private void Herstellen()
    {
        Vector3 abstand =new Vector3(Random.Range(-4f,4f),0,0);
        Instantiate(Hindernisse[GameManager.Instance.Level % Hindernisse.Length], transform.position + abstand, transform.rotation);
        spawndelay=spawndelay*0.95f;
    }

    // Update is called once per frame
    void Update()
    {
        spawndelay=2/(GameManager.Instance.Level*0.25f+1);
    }
    IEnumerator SpawnCoroutine()
    {
        Herstellen();
        yield return new WaitForSeconds(spawndelay);
    }
}
