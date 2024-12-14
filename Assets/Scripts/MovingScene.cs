using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MovingScene : MonoBehaviour
{
    [SerializeField] Button button;
    // Start is called before the first frame update
    void Start()
    {
        if(button != null){
            button.onClick.AddListener(OnButtonClick);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnButtonClick(){
        SceneManager.LoadScene(0);
    }
}
