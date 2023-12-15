using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GunListScriptable gunList;

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

    public void PlayButton()
    {
        SceneManager.LoadScene(currentLevelIndex + 1);
    }

    public void LeftButton()
    {
       if(currentLevelIndex > 0)
        {
           currentLevelIndex--;
           gunNameTitle.text = gunList.guns[currentLevelIndex].gunName;
           if(menuGunParent.childCount > 0)
              Destroy(menuGunParent.GetChild(0).gameObject);
            Instantiate(gunList.guns[currentLevelIndex].menuGan, menuGunParent);
        }
    }

    public void RightButton()
    {
        if(currentLevelIndex < gunList.guns.Length-1)
        {
            currentLevelIndex++;
            gunNameTitle.text = gunList.guns[currentLevelIndex].gunName;
            if (menuGunParent.childCount > 0)
                Destroy(menuGunParent.GetChild(0).gameObject);
            Instantiate(gunList.guns[currentLevelIndex].menuGan, menuGunParent);
        }
    }

    
}
