using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenShop : MonoBehaviour
{
    public GameObject shopUpgradesActual;
    public Animator shopUpgrades;
    public Animator shopUp;
    public Button shopButton;
    public Image blockPress;
    public Image shopBackground;
    
    void Start()
    {
        shopBackground.gameObject.SetActive(false);
        blockPress.gameObject.SetActive(false);
    }

    
    void Update()
    {
        
    }
    
    public void onClick()
    {
        StartCoroutine(ShowShopRoutine());
    }

    private IEnumerator ShowShopRoutine()
    {
        if (shopBackground.gameObject.activeSelf == false)
        {
            shopButton.enabled = false;
            shopUpgradesActual.gameObject.SetActive(true);
            shopBackground.gameObject.SetActive(true);
            blockPress.gameObject.SetActive(true);
            shopUp.Play("Base Layer.ShopOpenAnimation");
            shopUpgrades.Play("ShopUpgradeButtonsUp");
            print("Opened Shop");
            yield return new WaitForSeconds(1.5f);
            shopButton.enabled = true;
        }
        else
        {
            shopButton.enabled = false;
            shopUp.Play("Base Layer.ShopCloseAnimation");
            shopUpgrades.Play("ShopUpgradeButtonsDown");
            print("Closed Shop");
            yield return new WaitForSeconds(1);
            shopUpgradesActual.gameObject.SetActive(false);
            blockPress.gameObject.SetActive(false);
            shopBackground.gameObject.SetActive(false);
            shopButton.enabled = true;
        }
        yield return null;
    }


}
