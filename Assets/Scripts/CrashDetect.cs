using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetect : MonoBehaviour
{
    private int crashCount = 0;  // count of crashes
    private void OnTriggerEnter2D(Collider2D other)
    {
        crashCount++;
        Debug.Log("Damn, it hits hard! Crash count: " + crashCount);

        if (crashCount >= 3)
        {
            Debug.Log("Too many crashes. Restarting level...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
