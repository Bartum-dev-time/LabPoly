using UnityEngine;
using UnityEngine.SceneManagement;
public class CambioScena : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(1);
    }

}
