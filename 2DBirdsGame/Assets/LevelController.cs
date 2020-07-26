using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private static int _nextlevelIndex = 1;
    private Enemy[] _enemies;

    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Enemy enemy in _enemies)
        {
            if (enemy != null)
            {
                return;
            }

        }

        Debug.Log("You killed all enemies!! You monster");

        _nextlevelIndex++;
        string nextLevelName = "Level" + _nextlevelIndex;
        SceneManager.LoadScene(nextLevelName);
    }
}
