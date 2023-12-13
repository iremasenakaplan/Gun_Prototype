using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{
    //[SerializeField] GunListScriptable gunList;

    int currentLevelIndex = 0;

    [SerializeField] Transform menuGunParent;
    [SerializeField] TMP_Text gunNameTitle;

    [SerializeField] Button playButton;
    [SerializeField] Button rightButton;
    [SerializeField] Button leftButton;
    
    void Start()
    {
        RightButton();
        LeftButton();
    }

    void PlayButton()
    {
        SceneManager.LoadScene(currentLevelIndex + 1);
    }

    void RightButton()
    {

    }

    void LeftButton()
    {

    }
  
}
