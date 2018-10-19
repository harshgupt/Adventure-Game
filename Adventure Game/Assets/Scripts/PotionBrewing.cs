using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotionBrewing : MonoBehaviour {

    public Camera cam;

    public Blade bladeUIScript;

    public PlayerData pData;

    public GameObject bladeUI;
    public GameObject cauldronUI;
    public GameObject LP1;
    public GameObject DP1;
    public GameObject HP1;
    public GameObject AP1;
    public GameObject MP1;
    public GameObject LP2;
    public GameObject DP2;
    public GameObject HP2;
    public GameObject AP2;
    public GameObject MP2;
    public GameObject LP3;
    public GameObject DP3;
    public GameObject HP3;
    public GameObject AP3;
    public GameObject MP3;
    public GameObject LP4;
    public GameObject DP4;
    public GameObject HP4;
    public GameObject AP4;
    public GameObject MP4;
    public GameObject LP5;
    public GameObject DP5;
    public GameObject HP5;
    public GameObject AP5;
    public GameObject MP5;
    public GameObject LP6;
    public GameObject DP6;
    public GameObject HP6;
    public GameObject AP6;
    public GameObject MP6;
    public GameObject marvelousPotion;
    public GameObject ingredientObject;

    public Image progressBar;
    public Image ingredient;
    public Image inventoryImage;
    
    public Sprite ingredient1;
    public Sprite ingredient2;

    public Text inventoryAmount;

    public Vector3 ingredientPos;

    public Vector2 startPosition;
    public Vector2 currentPosition;
    public Vector2 prevPosition;
    public Vector2 circleCenter = new Vector2(0, 0);
    public Vector2 touchPosition;

    private const float circleRadius = 3f;
    public float angle;

    public int maxNumTurns = 10;
    public int currentPotion = 0;
    public int herbIngredient;
    public int fruitIngredient;

    public bool isDrawing = false;
    public bool movedOut = false;
    public bool addedIngredient1 = false;
    public bool addedIngredient2 = false;
    public bool secondStage = false;

    private void Start()
    {
        ingredientPos = ingredientObject.transform.position;
    }

    private void Update()
    {
        DisplayInventoryAmount();
#if !UNITY_EDITOR
        Touch touch = Input.touches[0];
        if(touch.phase == TouchPhase.Began && (addedIngredient1 || addedIngredient2))
        {
            if (Vector2.Distance(circleCenter, cam.ScreenToWorldPoint(touch.position)) <= circleRadius)
            {
                touchPosition = cam.ScreenToWorldPoint(touch.position);
                StartDrawing();
            }
        }
        if(touch.phase == TouchPhase.Ended)
        {
            StopDrawing();
        }
        if(touch.phase == TouchPhase.Moved)
        {
            if (Vector2.Distance(circleCenter, cam.ScreenToWorldPoint(touch.position)) <= circleRadius && movedOut)
            {
                movedOut = false;
                touchPosition = cam.ScreenToWorldPoint(touch.position);
                StartDrawing();
            }
        }
        if (touch.phase == TouchPhase.Began && !addedIngredient1 && !addedIngredient2)
        {
            MouseDrag.condition = true;
        }
        if (touch.phase == TouchPhase.Ended && MouseDrag.holding)
        {
            MouseDrag.holding = false;
            if (Vector2.Distance(circleCenter, cam.ScreenToWorldPoint(touch.position)) <= circleRadius)
            {
                MouseDrag.condition = false;
                if (!secondStage)
                {
                    AfterFirstIngredient();
                }
                else
                {
                    AfterSecondIngredient();
                }
            }
            ingredientObject.transform.position = ingredientPos;
        }
#else
        if (Input.GetMouseButtonDown(0) && (addedIngredient1 || addedIngredient2))
        {
            if (Vector2.Distance(circleCenter, cam.ScreenToWorldPoint(Input.mousePosition)) <= circleRadius)
            {
                touchPosition = cam.ScreenToWorldPoint(Input.mousePosition);
                StartDrawing();
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            StopDrawing();
        }
        if(Input.GetMouseButtonDown(0) && !addedIngredient1 && !addedIngredient2)
        {
            MouseDrag.condition = true;
        }
        if(Input.GetMouseButtonUp(0) && MouseDrag.holding)
        {
            MouseDrag.holding = false;
            if(Vector2.Distance(circleCenter, cam.ScreenToWorldPoint(Input.mousePosition)) <= circleRadius)
            {
                MouseDrag.condition = false;
                if (!secondStage)
                {
                    AfterFirstIngredient();
                }
                else
                {
                    AfterSecondIngredient();
                }
            }
            ingredientObject.transform.position = ingredientPos;
        }
#endif
        if (isDrawing)
        {
#if !UNITY_EDITOR
            touchPosition = cam.ScreenToWorldPoint(touch.position);
#else
            touchPosition = cam.ScreenToWorldPoint(Input.mousePosition);
#endif
            if (Vector2.Distance(circleCenter, touchPosition) <= circleRadius)
            {
                if(angle <= maxNumTurns * 360 / 2)
                {
                    Vector2 v1 = prevPosition - circleCenter;
                    currentPosition = touchPosition;
                    Vector2 v2 = currentPosition - circleCenter;
                    Vector2 v3 = startPosition - circleCenter;
                    if (Vector2.SignedAngle(v2, v1) > 0)
                    {
                        angle += Vector2.SignedAngle(v2, v1);
                    }
                    int numTurns = (int)angle / 360;
                    progressBar.fillAmount = (float)numTurns / maxNumTurns;
                    prevPosition = currentPosition;
                    if (angle >= maxNumTurns * 360 / 2)
                    {
                        BeforeSecondIngredient();
                    }
                }
                else if(angle >= maxNumTurns * 360 / 2 && angle <= maxNumTurns * 360 && addedIngredient2)
                {
                    Vector2 v1 = prevPosition - circleCenter;
                    currentPosition = touchPosition;
                    Vector2 v2 = currentPosition - circleCenter;
                    Vector2 v3 = startPosition - circleCenter;
                    if (Vector2.SignedAngle(v1, v2) > 0)
                    {
                        angle += Vector2.SignedAngle(v1, v2);
                    }
                    int numTurns = (int)angle / 360;
                    progressBar.fillAmount = (float)numTurns / maxNumTurns;
                    prevPosition = currentPosition;
                }
                else if(angle >= maxNumTurns * 360)
                {
                    angle = 0;
                    addedIngredient2 = false;
                    pData.herbs[herbIngredient].amount--;
                    pData.fruits[fruitIngredient].amount--;
                    pData.potions[currentPotion].amount++;
                    secondStage = false;
                    if (bladeUI.activeSelf)
                    {
                        bladeUIScript.StopCuttingForUI();
                        bladeUI.SetActive(false);
                    }
                    cauldronUI.SetActive(false);
                }
            }
            else
            {
                movedOut = true;
                StopDrawing();
            }
        }
    }

    public void StartBrewing()
    {
        ingredient.sprite = ingredient1;
    }

    public void AfterFirstIngredient()
    {
        addedIngredient1 = true;
        Color color = ingredient.color;
        color.a = 0;
        ingredient.color = color;
    }

    public void BeforeSecondIngredient()
    {
        addedIngredient1 = false;
        secondStage = true;
        ingredient.sprite = ingredient2;
        Color color = ingredient.color;
        color.a = 1;
        ingredient.color = color;
    }

    public void AfterSecondIngredient()
    {
        addedIngredient2 = true;
        Color color = ingredient.color;
        color.a = 0;
        ingredient.color = color;
    }

    public void StartDrawing()
    {
        startPosition = touchPosition;
        currentPosition = touchPosition;
        prevPosition = touchPosition;
        isDrawing = true;
    }

    public void StopDrawing()
    {
        isDrawing = false;
    }

    public void Close()
    {
        transform.gameObject.SetActive(false);
    }

    public void CloseBrewing()
    {
        if (bladeUI.activeSelf)
        {
            bladeUIScript.StopCuttingForUI();
            bladeUI.SetActive(false);
        }
        cauldronUI.SetActive(false);
    }

    public void ResetAll()
    {
        bladeUI.SetActive(true);
        ingredient.sprite = null;
        progressBar.fillAmount = 0;
        angle = 0;
        secondStage = false;
        addedIngredient1 = false;
        addedIngredient2 = false;
        ingredientObject.transform.position = ingredientPos;
        Color color = ingredient.color;
        color.a = 1;
        ingredient.color = color;
    }

    public void DisplayInventoryAmount()
    {
        inventoryImage.sprite = pData.potions[currentPotion].sprite;
        inventoryAmount.text = pData.potions[currentPotion].amount.ToString();
    }

    public void LP1Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 0;
        fruitIngredient = 0;
        ingredient1 = pData.herbs[0].sprite;
        ingredient2 = pData.fruits[0].sprite;
        if (pData.herbs[0].amount > 0 && pData.fruits[0].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void DP1Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 1;
        fruitIngredient = 0;
        ingredient1 = pData.herbs[1].sprite;
        ingredient2 = pData.fruits[0].sprite;
        if (pData.herbs[1].amount > 0 && pData.fruits[0].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void HP1Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 2;
        fruitIngredient = 0;
        ingredient1 = pData.herbs[2].sprite;
        ingredient2 = pData.fruits[0].sprite;
        if (pData.herbs[2].amount > 0 && pData.fruits[0].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void AP1Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 3;
        fruitIngredient = 0;
        ingredient1 = pData.herbs[3].sprite;
        ingredient2 = pData.fruits[0].sprite;
        if (pData.herbs[3].amount > 0 && pData.fruits[0].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void MP1Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 4;
        fruitIngredient = 0;
        ingredient1 = pData.herbs[4].sprite;
        ingredient2 = pData.fruits[0].sprite;
        if (pData.herbs[4].amount > 0 && pData.fruits[0].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void LP2Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 5;
        fruitIngredient = 1;
        ingredient1 = pData.herbs[5].sprite;
        ingredient2 = pData.fruits[1].sprite;
        if (pData.herbs[5].amount > 0 && pData.fruits[1].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void DP2Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 6;
        fruitIngredient = 1;
        ingredient1 = pData.herbs[6].sprite;
        ingredient2 = pData.fruits[1].sprite;
        if (pData.herbs[6].amount > 0 && pData.fruits[1].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void HP2Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 7;
        fruitIngredient = 1;
        ingredient1 = pData.herbs[7].sprite;
        ingredient2 = pData.fruits[1].sprite;
        if (pData.herbs[7].amount > 0 && pData.fruits[1].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void AP2Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 8;
        fruitIngredient = 1;
        ingredient1 = pData.herbs[8].sprite;
        ingredient2 = pData.fruits[1].sprite;
        if (pData.herbs[8].amount > 0 && pData.fruits[1].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void MP2Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 9;
        fruitIngredient = 1;
        ingredient1 = pData.herbs[9].sprite;
        ingredient2 = pData.fruits[1].sprite;
        if (pData.herbs[9].amount > 0 && pData.fruits[1].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void LP3Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 10;
        fruitIngredient = 2;
        ingredient1 = pData.herbs[10].sprite;
        ingredient2 = pData.fruits[2].sprite;
        if (pData.herbs[10].amount > 0 && pData.fruits[2].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void DP3Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 11;
        fruitIngredient = 2;
        ingredient1 = pData.herbs[11].sprite;
        ingredient2 = pData.fruits[2].sprite;
        if (pData.herbs[11].amount > 0 && pData.fruits[2].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void HP3Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 12;
        fruitIngredient = 2;
        ingredient1 = pData.herbs[12].sprite;
        ingredient2 = pData.fruits[2].sprite;
        if (pData.herbs[12].amount > 0 && pData.fruits[2].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void AP3Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 13;
        fruitIngredient = 2;
        ingredient1 = pData.herbs[13].sprite;
        ingredient2 = pData.fruits[2].sprite;
        if (pData.herbs[13].amount > 0 && pData.fruits[2].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void MP3Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 14;
        fruitIngredient = 2;
        ingredient1 = pData.herbs[14].sprite;
        ingredient2 = pData.fruits[2].sprite;
        if (pData.herbs[14].amount > 0 && pData.fruits[2].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void LP4Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 15;
        fruitIngredient = 3;
        ingredient1 = pData.herbs[15].sprite;
        ingredient2 = pData.fruits[3].sprite;
        if (pData.herbs[15].amount > 0 && pData.fruits[3].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void DP4Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 16;
        fruitIngredient = 3;
        ingredient1 = pData.herbs[16].sprite;
        ingredient2 = pData.fruits[3].sprite;
        if (pData.herbs[16].amount > 0 && pData.fruits[3].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void HP4Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 17;
        fruitIngredient = 3;
        ingredient1 = pData.herbs[17].sprite;
        ingredient2 = pData.fruits[3].sprite;
        if (pData.herbs[17].amount > 0 && pData.fruits[3].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void AP4Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 18;
        fruitIngredient = 3;
        ingredient1 = pData.herbs[18].sprite;
        ingredient2 = pData.fruits[3].sprite;
        if (pData.herbs[18].amount > 0 && pData.fruits[3].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void MP4Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 19;
        fruitIngredient = 3;
        ingredient1 = pData.herbs[19].sprite;
        ingredient2 = pData.fruits[3].sprite;
        if (pData.herbs[19].amount > 0 && pData.fruits[3].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void LP5Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 20;
        fruitIngredient = 4;
        ingredient1 = pData.herbs[20].sprite;
        ingredient2 = pData.fruits[4].sprite;
        if (pData.herbs[20].amount > 0 && pData.fruits[4].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void DP5Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 21;
        fruitIngredient = 4;
        ingredient1 = pData.herbs[21].sprite;
        ingredient2 = pData.fruits[4].sprite;
        if (pData.herbs[21].amount > 0 && pData.fruits[4].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void HP5Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 22;
        fruitIngredient = 4;
        ingredient1 = pData.herbs[22].sprite;
        ingredient2 = pData.fruits[4].sprite;
        if (pData.herbs[22].amount > 0 && pData.fruits[4].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void AP5Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 23;
        fruitIngredient = 4;
        ingredient1 = pData.herbs[23].sprite;
        ingredient2 = pData.fruits[4].sprite;
        if (pData.herbs[23].amount > 0 && pData.fruits[4].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void MP5Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 24;
        fruitIngredient = 4;
        ingredient1 = pData.herbs[24].sprite;
        ingredient2 = pData.fruits[4].sprite;
        if (pData.herbs[24].amount > 0 && pData.fruits[4].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void LP6Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 25;
        fruitIngredient = 5;
        ingredient1 = pData.herbs[25].sprite;
        ingredient2 = pData.fruits[5].sprite;
        if (pData.herbs[25].amount > 0 && pData.fruits[5].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void DP6Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 26;
        fruitIngredient = 5;
        ingredient1 = pData.herbs[26].sprite;
        ingredient2 = pData.fruits[5].sprite;
        if (pData.herbs[26].amount > 0 && pData.fruits[5].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void HP6Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 27;
        fruitIngredient = 5;
        ingredient1 = pData.herbs[27].sprite;
        ingredient2 = pData.fruits[5].sprite;
        if (pData.herbs[27].amount > 0 && pData.fruits[5].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void AP6Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 28;
        fruitIngredient = 5;
        ingredient1 = pData.herbs[28].sprite;
        ingredient2 = pData.fruits[5].sprite;
        if (pData.herbs[28].amount > 0 && pData.fruits[5].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }

    public void MP6Brew()
    {
        ResetAll();
        maxNumTurns = 8;
        herbIngredient = 29;
        fruitIngredient = 5;
        ingredient1 = pData.herbs[29].sprite;
        ingredient2 = pData.fruits[5].sprite;
        if (pData.herbs[29].amount > 0 && pData.fruits[5].amount > 0)
        {
            StartBrewing();
            cauldronUI.SetActive(true);
        }
        else
        {
            return;
        }

    }
    
    public void MarvelousPotionBrew()
    {
        return;
    }

    public void LeftButton()
    {
        switch (currentPotion)
        {
            case 0:
                return;
            case 1:
                LP1.SetActive(true);
                DP1.SetActive(false);
                currentPotion--;
                break;
            case 2:
                DP1.SetActive(true);
                HP1.SetActive(false);
                currentPotion--;
                break;
            case 3:
                HP1.SetActive(true);
                AP1.SetActive(false);
                currentPotion--;
                break;
            case 4:
                AP1.SetActive(true);
                MP1.SetActive(false);
                currentPotion--;
                break;
            case 5:
                MP1.SetActive(true);
                LP2.SetActive(false);
                currentPotion--;
                break;
            case 6:
                LP2.SetActive(true);
                DP2.SetActive(false);
                currentPotion--;
                break;
            case 7:
                DP2.SetActive(true);
                HP2.SetActive(false);
                currentPotion--;
                break;
            case 8:
                HP2.SetActive(true);
                AP2.SetActive(false);
                currentPotion--;
                break;
            case 9:
                AP2.SetActive(true);
                MP2.SetActive(false);
                currentPotion--;
                break;
            case 10:
                MP2.SetActive(true);
                LP3.SetActive(false);
                currentPotion--;
                break;
            case 11:
                LP3.SetActive(true);
                DP3.SetActive(false);
                currentPotion--;
                break;
            case 12:
                DP3.SetActive(true);
                HP3.SetActive(false);
                currentPotion--;
                break;
            case 13:
                HP3.SetActive(true);
                AP3.SetActive(false);
                currentPotion--;
                break;
            case 14:
                AP3.SetActive(true);
                MP3.SetActive(false);
                currentPotion--;
                break;
            case 15:
                MP3.SetActive(true);
                LP4.SetActive(false);
                currentPotion--;
                break;
            case 16:
                LP4.SetActive(true);
                DP4.SetActive(false);
                currentPotion--;
                break;
            case 17:
                DP4.SetActive(true);
                HP4.SetActive(false);
                currentPotion--;
                break;
            case 18:
                HP4.SetActive(true);
                AP4.SetActive(false);
                currentPotion--;
                break;
            case 19:
                AP4.SetActive(true);
                MP4.SetActive(false);
                currentPotion--;
                break;
            case 20:
                MP4.SetActive(true);
                LP5.SetActive(false);
                currentPotion--;
                break;
            case 21:
                LP5.SetActive(true);
                DP5.SetActive(false);
                currentPotion--;
                break;
            case 22:
                DP5.SetActive(true);
                HP5.SetActive(false);
                currentPotion--;
                break;
            case 23:
                HP5.SetActive(true);
                AP5.SetActive(false);
                currentPotion--;
                break;
            case 24:
                AP5.SetActive(true);
                MP5.SetActive(false);
                currentPotion--;
                break;
            case 25:
                MP5.SetActive(true);
                LP6.SetActive(false);
                currentPotion--;
                break;
            case 26:
                LP6.SetActive(true);
                DP6.SetActive(false);
                currentPotion--;
                break;
            case 27:
                DP6.SetActive(true);
                HP6.SetActive(false);
                currentPotion--;
                break;
            case 28:
                HP6.SetActive(true);
                AP6.SetActive(false);
                currentPotion--;
                break;
            case 29:
                AP6.SetActive(true);
                MP6.SetActive(false);
                currentPotion--;
                break;
            case 30:
                MP6.SetActive(true);
                marvelousPotion.SetActive(false);
                currentPotion--;
                break;
            default:
                return;
        }
    }

    public void RightButton()
    {
        switch (currentPotion)
        {
            case 0:
                LP1.SetActive(false);
                DP1.SetActive(true);
                currentPotion++;
                break;
            case 1:
                DP1.SetActive(false);
                HP1.SetActive(true);
                currentPotion++;
                break;
            case 2:
                HP1.SetActive(false);
                AP1.SetActive(true);
                currentPotion++;
                break;
            case 3:
                AP1.SetActive(false);
                MP1.SetActive(true);
                currentPotion++;
                break;
            case 4:
                MP1.SetActive(false);
                LP2.SetActive(true);
                currentPotion++;
                break;
            case 5:
                LP2.SetActive(false);
                DP2.SetActive(true);
                currentPotion++;
                break;
            case 6:
                DP2.SetActive(false);
                HP2.SetActive(true);
                currentPotion++;
                break;
            case 7:
                HP2.SetActive(false);
                AP2.SetActive(true);
                currentPotion++;
                break;
            case 8:
                AP2.SetActive(false);
                MP2.SetActive(true);
                currentPotion++;
                break;
            case 9:
                MP2.SetActive(false);
                LP3.SetActive(true);
                currentPotion++;
                break;
            case 10:
                LP3.SetActive(false);
                DP3.SetActive(true);
                currentPotion++;
                break;
            case 11:
                DP3.SetActive(false);
                HP3.SetActive(true);
                currentPotion++;
                break;
            case 12:
                HP3.SetActive(false);
                AP3.SetActive(true);
                currentPotion++;
                break;
            case 13:
                AP3.SetActive(false);
                MP3.SetActive(true);
                currentPotion++;
                break;
            case 14:
                MP3.SetActive(false);
                LP4.SetActive(true);
                currentPotion++;
                break;
            case 15:
                LP4.SetActive(false);
                DP4.SetActive(true);
                currentPotion++;
                break;
            case 16:
                DP4.SetActive(false);
                HP4.SetActive(true);
                currentPotion++;
                break;
            case 17:
                HP4.SetActive(false);
                AP4.SetActive(true);
                currentPotion++;
                break;
            case 18:
                AP4.SetActive(false);
                MP4.SetActive(true);
                currentPotion++;
                break;
            case 19:
                MP4.SetActive(false);
                LP5.SetActive(true);
                currentPotion++;
                break;
            case 20:
                LP5.SetActive(false);
                DP5.SetActive(true);
                currentPotion++;
                break;
            case 21:
                DP5.SetActive(false);
                HP5.SetActive(true);
                currentPotion++;
                break;
            case 22:
                HP5.SetActive(false);
                AP5.SetActive(true);
                currentPotion++;
                break;
            case 23:
                AP5.SetActive(false);
                MP5.SetActive(true);
                currentPotion++;
                break;
            case 24:
                MP5.SetActive(false);
                LP6.SetActive(true);
                currentPotion++;
                break;
            case 25:
                LP6.SetActive(false);
                DP6.SetActive(true);
                currentPotion++;
                break;
            case 26:
                DP6.SetActive(false);
                HP6.SetActive(true);
                currentPotion++;
                break;
            case 27:
                HP6.SetActive(false);
                AP6.SetActive(true);
                currentPotion++;
                break;
            case 28:
                AP6.SetActive(false);
                MP6.SetActive(true);
                currentPotion++;
                break;
            case 29:
                MP6.SetActive(false);
                marvelousPotion.SetActive(true);
                currentPotion++;
                break;
            case 30:
                return;
            default:
                return;
        }
    }
}
