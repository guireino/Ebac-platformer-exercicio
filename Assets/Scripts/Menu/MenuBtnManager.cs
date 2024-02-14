using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBtnManager : MonoBehaviour{
    
    public void Load(int i){
        SceneManager.LoadScene(i);
    }

    public void Quit(){
        Application.Quit(); // fazendo sair do jogo
    }
}