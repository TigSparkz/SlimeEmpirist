using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    // Stuff to drop after
    public GameObject moneyManagement;
    public Image topBar;
    public TextMeshProUGUI userName;
    public Button shopButton;
    public Button azureUprade;

    // Side Animators
    public Animator topBarDrop;
    public Animator minesSide;
    public Animator shopUp;
    public Animator mineUpgrades;
    public Animator moneyDrop;

    // 218.5
    // Main Animators
    public Animator textBox;
    public Animator fadeIn;
    public Animator plaque1Anim;
    public Animator plaque2Anim;

    // Main stuff for game opening
    public GameObject speechBubble;
    private int nameToInt;
    public TMP_InputField inputNameBox;
    private int length;
    public GameObject inputField;
    private string nameInput;
    private int delay;
    public int startInstantiate = 0;
    public Button nextButton;
    public Image blockAll;
    public Image plaque1;
    public Image plaque2;

    void Start()
    {
        delay = 0;
        plaque2.enabled = false;
        nextButton.enabled = false;
        blockAll.gameObject.SetActive(true);
        plaque1Anim.Play("FirstPlaqueUp");
        inputField.gameObject.SetActive(false);
        Invoke("enableButton", 0.75f);
    }
    void Update()
    {  
        if (plaque1.transform.position.y >= 6.5)
        {
            plaque1.gameObject.SetActive(false);
        }
        if (plaque2.transform.position.y >= 0)
        {
            inputField.gameObject.SetActive(true);
            delay = 2;
        }
        if (plaque2.transform.position.y >= 6.5)
        {
            plaque2.gameObject.SetActive(false);
        }
        StartCoroutine(unlockGame());
    }
    public void onValueChanged()
    {
        nameInput = inputNameBox.text.ToString();
        length = 3;
        nameToInt = nameInput.Length;
        print(nameInput);

    }

    public void onPress()
    {
        StartCoroutine(nextPlaque());
    }
    public void enableButton()
    {
        nextButton.enabled = true;
    }

    IEnumerator nextPlaque()
    {
        if (plaque1.gameObject.activeSelf == true)
        {
            plaque2.enabled = true;
            plaque1Anim.Play("FirstPlaqueExit");
            plaque2Anim.Play("SecondPlaqueUp");
            nextButton.gameObject.SetActive(false);
            Invoke("enableButton", 0.75f);
            yield return null;
        }
        if (plaque2.gameObject.activeSelf == true && delay == 1)
        {
            nextButton.enabled = false;
            Invoke("enableButton", 0.75f);
            yield return null;
        }
        delay = 1;

    }
    IEnumerator unlockGame()
    {
        if (Input.GetKey(KeyCode.Return) && delay == 2 && nameToInt > length)
        {
            userName.text = nameInput;
            textBox.Play("TextBoxGo");
            fadeIn.Play("FadeIn");
            plaque2Anim.Play("SecondPlaqueExit");

            yield return new WaitForSeconds(1);
            inputField.gameObject.SetActive(false);

            StartCoroutine(assetDrop());
        }
        if (Input.GetKey(KeyCode.Return) && delay == 2 && nameToInt < length)
        {
            speechBubble.SetActive(true);
            Invoke("disableBubble", 1);
        }
    }
    public void disableBubble()
    {
        speechBubble.SetActive (false);
    }
    IEnumerator assetDrop()
    {
        topBarDrop.Play("TopBarDrop");
        yield return new WaitForSeconds(0.4f);
        minesSide.Play("MinesSideAnim");
        yield return new WaitForSeconds(0.4f);
        shopUp.Play("ShopButtonUp");
        yield return new WaitForSeconds(0.4f);
        mineUpgrades.Play("UpgradeButtons");
        yield return new WaitForSeconds(0.4f);
        moneyDrop.Play("MoneyDropAnim");
        yield return new WaitForSeconds(0.4f);
        startInstantiate = 1;
        blockAll.gameObject.SetActive(false);
        

    }


}
