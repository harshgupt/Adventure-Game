using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HerbGarden : MonoBehaviour {

    public Blade bladeUIScript;

    public PlayerData pData;

    public GameObject bladeUI;
    public GameObject clover;
    public GameObject holly;
    public GameObject ivySprig;
    public GameObject willowTwig;
    public GameObject roseThorn;
    public GameObject goosegrass;
    public GameObject windrush;
    public GameObject firegrass;
    public GameObject daisyPetal;
    public GameObject moly;
    public GameObject knotweed;
    public GameObject bitterroot;
    public GameObject baneberry;
    public GameObject starthistle;
    public GameObject mandrakeRoot;
    public GameObject spleenwort;
    public GameObject tawnymothWeed;
    public GameObject dragonIvy;
    public GameObject valerianRoot;
    public GameObject helleboreSyrup;
    public GameObject wormwood;
    public GameObject silverweed;
    public GameObject wolfsbane;
    public GameObject moondew;
    public GameObject asphodel;
    public GameObject fluxweed;
    public GameObject nightshade;
    public GameObject belladonna;
    public GameObject tormentil;
    public GameObject bloodroot;

    public Image inventoryImage;

    public Text inventoryAmount;

    public int currentHerb = 0;

    private void Update()
    {
        DisplayInventoryAmount();
    }

    public void DisplayInventoryAmount()
    {
        inventoryImage.sprite = pData.herbs[currentHerb].sprite;
        inventoryAmount.text = pData.herbs[currentHerb].amount.ToString();
    }

    public void LeftButton()
    {
        switch (currentHerb)
        {
            case 0:
                return;
            case 1:
                clover.SetActive(true);
                daisyPetal.SetActive(false);
                currentHerb--;
                break;
            case 2:
                daisyPetal.SetActive(true);
                holly.SetActive(false);
                currentHerb--;
                break;
            case 3:
                holly.SetActive(true);
                roseThorn.SetActive(false);
                currentHerb--;
                break;
            case 4:
                roseThorn.SetActive(true);
                ivySprig.SetActive(false);
                currentHerb--;
                break;
            case 5:
                ivySprig.SetActive(true);
                windrush.SetActive(false);
                currentHerb--;
                break;
            case 6:
                windrush.SetActive(true);
                willowTwig.SetActive(false);
                currentHerb--;
                break;
            case 7:
                willowTwig.SetActive(true);
                goosegrass.SetActive(false);
                currentHerb--;
                break;
            case 8:
                goosegrass.SetActive(true);
                firegrass.SetActive(false);
                currentHerb--;
                break;
            case 9:
                firegrass.SetActive(true);
                moly.SetActive(false);
                currentHerb--;
                break;
            case 10:
                moly.SetActive(true);
                starthistle.SetActive(false);
                currentHerb--;
                break;
            case 11:
                starthistle.SetActive(true);
                knotweed.SetActive(false);
                currentHerb--;
                break;
            case 12:
                knotweed.SetActive(true);
                bitterroot.SetActive(false);
                currentHerb--;
                break;
            case 13:
                bitterroot.SetActive(true);
                baneberry.SetActive(false);
                currentHerb--;
                break;
            case 14:
                baneberry.SetActive(true);
                mandrakeRoot.SetActive(false);
                currentHerb--;
                break;
            case 15:
                mandrakeRoot.SetActive(true);
                tawnymothWeed.SetActive(false);
                currentHerb--;
                break;
            case 16:
                tawnymothWeed.SetActive(true);
                spleenwort.SetActive(false);
                currentHerb--;
                break;
            case 17:
                spleenwort.SetActive(true);
                helleboreSyrup.SetActive(false);
                currentHerb--;
                break;
            case 18:
                helleboreSyrup.SetActive(true);
                valerianRoot.SetActive(false);
                currentHerb--;
                break;
            case 19:
                valerianRoot.SetActive(true);
                dragonIvy.SetActive(false);
                currentHerb--;
                break;
            case 20:
                dragonIvy.SetActive(true);
                asphodel.SetActive(false);
                currentHerb--;
                break;
            case 21:
                asphodel.SetActive(true);
                wormwood.SetActive(false);
                currentHerb--;
                break;
            case 22:
                wormwood.SetActive(true);
                silverweed.SetActive(false);
                currentHerb--;
                break;
            case 23:
                silverweed.SetActive(true);
                wolfsbane.SetActive(false);
                currentHerb--;
                break;
            case 24:
                wolfsbane.SetActive(true);
                moondew.SetActive(false);
                currentHerb--;
                break;
            case 25:
                moondew.SetActive(true);
                fluxweed.SetActive(false);
                currentHerb--;
                break;
            case 26:
                fluxweed.SetActive(true);
                tormentil.SetActive(false);
                currentHerb--;
                break;
            case 27:
                tormentil.SetActive(true);
                belladonna.SetActive(false);
                currentHerb--;
                break;
            case 28:
                belladonna.SetActive(true);
                nightshade.SetActive(false);
                currentHerb--;
                break;
            case 29:
                nightshade.SetActive(true);
                bloodroot.SetActive(false);
                currentHerb--;
                break;
            default:
                return;
        }
    }

    public void RightButton()
    {
        switch (currentHerb)
        {
            case 0:
                clover.SetActive(false);
                daisyPetal.SetActive(true);
                currentHerb++;
                break;
            case 1:
                daisyPetal.SetActive(false);
                holly.SetActive(true);
                currentHerb++;
                break;
            case 2:
                holly.SetActive(false);
                roseThorn.SetActive(true);
                currentHerb++;
                break;
            case 3:
                roseThorn.SetActive(false);
                ivySprig.SetActive(true);
                currentHerb++;
                break;
            case 4:
                ivySprig.SetActive(false);
                windrush.SetActive(true);
                currentHerb++;
                break;
            case 5:
                windrush.SetActive(false);
                willowTwig.SetActive(true);
                currentHerb++;
                break;
            case 6:
                willowTwig.SetActive(false);
                goosegrass.SetActive(true);
                currentHerb++;
                break;
            case 7:
                goosegrass.SetActive(false);
                firegrass.SetActive(true);
                currentHerb++;
                break;
            case 8:
                firegrass.SetActive(false);
                moly.SetActive(true);
                currentHerb++;
                break;
            case 9:
                moly.SetActive(false);
                starthistle.SetActive(true);
                currentHerb++;
                break;
            case 10:
                starthistle.SetActive(false);
                knotweed.SetActive(true);
                currentHerb++;
                break;
            case 11:
                knotweed.SetActive(false);
                bitterroot.SetActive(true);
                currentHerb++;
                break;
            case 12:
                bitterroot.SetActive(false);
                baneberry.SetActive(true);
                currentHerb++;
                break;
            case 13:
                baneberry.SetActive(false);
                mandrakeRoot.SetActive(true);
                currentHerb++;
                break;
            case 14:
                mandrakeRoot.SetActive(false);
                tawnymothWeed.SetActive(true);
                currentHerb++;
                break;
            case 15:
                tawnymothWeed.SetActive(false);
                spleenwort.SetActive(true);
                currentHerb++;
                break;
            case 16:
                spleenwort.SetActive(false);
                helleboreSyrup.SetActive(true);
                currentHerb++;
                break;
            case 17:
                helleboreSyrup.SetActive(false);
                valerianRoot.SetActive(true);
                currentHerb++;
                break;
            case 18:
                valerianRoot.SetActive(false);
                dragonIvy.SetActive(true);
                currentHerb++;
                break;
            case 19:
                dragonIvy.SetActive(false);
                asphodel.SetActive(true);
                currentHerb++;
                break;
            case 20:
                asphodel.SetActive(false);
                wormwood.SetActive(true);
                currentHerb++;
                break;
            case 21:
                wormwood.SetActive(false);
                silverweed.SetActive(true);
                currentHerb++;
                break;
            case 22:
                silverweed.SetActive(false);
                wolfsbane.SetActive(true);
                currentHerb++;
                break;
            case 23:
                wolfsbane.SetActive(false);
                moondew.SetActive(true);
                currentHerb++;
                break;
            case 24:
                moondew.SetActive(false);
                fluxweed.SetActive(true);
                currentHerb++;
                break;
            case 25:
                fluxweed.SetActive(false);
                tormentil.SetActive(true);
                currentHerb++;
                break;
            case 26:
                tormentil.SetActive(false);
                belladonna.SetActive(true);
                currentHerb++;
                break;
            case 27:
                belladonna.SetActive(false);
                nightshade.SetActive(true);
                currentHerb++;
                break;
            case 28:
                nightshade.SetActive(false);
                bloodroot.SetActive(true);
                currentHerb++;
                break;
            case 29:
                return;
            default:
                return;
        }
    }

    public void Close()
    {
        if (bladeUI.activeSelf)
        {
            bladeUIScript.StopCuttingForUI();
            bladeUI.SetActive(false);
        }
        transform.gameObject.SetActive(false);
    }
}
