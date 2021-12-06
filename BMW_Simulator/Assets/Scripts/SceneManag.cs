using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManag : MonoBehaviour
{
    [SerializeField] private Button _play;
    [SerializeField] private Button _cars;

    public void LoadStart()
    {
        SceneManager.LoadScene(1);
    }
}
