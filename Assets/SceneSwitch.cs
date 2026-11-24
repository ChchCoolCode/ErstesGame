using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitch : MonoBehaviour
{
   [SerializeField] private string _SceneToLoad;
    public void SwitchScene()
    {
     SceneManager.LoadScene(_SceneToLoad);   
    }
}
