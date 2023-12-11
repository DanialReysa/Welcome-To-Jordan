using UnityEngine;
using UnityEngine.SceneManagement;

public class RefreshOnContact : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Refresh the game
            RefreshGame();
        }
    }

    private void RefreshGame()
    {
        // Get the current scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Reload the current scene
        SceneManager.LoadScene(currentSceneIndex);

        // Reset any other game variables or states here
        // For example, if you have a GameManager script with static variables, you can reset them like this:
        //GameManager.ResetGame();
    }
}
