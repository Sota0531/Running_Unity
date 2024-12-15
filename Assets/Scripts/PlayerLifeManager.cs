using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerLifeManager : MonoBehaviour
{
    private int maxLife = 5;
    private int nowLife = 5;

    [SerializeField] TMP_Text _LifeText;
    [SerializeField] PlayerGameOver playerGameOver;
    // Start is called before the first frame update
    void Start()
    {
        _LifeText.text = "Life:" + nowLife.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddLife(int addnum){
        if(nowLife < maxLife){
            if(nowLife + addnum <= maxLife){
                nowLife += addnum;
                
            }else{
                nowLife = maxLife;
            }
            _LifeText.text = "Life:" + nowLife.ToString();
        }
    }
    public void RemoveLife(int removenum){
        nowLife -= removenum;
        if(nowLife <= 0){
            playerGameOver.GameOver();
        }else{
            _LifeText.text = "Life:" + nowLife.ToString();
        }
    }
}
