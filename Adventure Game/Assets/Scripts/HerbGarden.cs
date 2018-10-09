using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerbGarden : MonoBehaviour {
    
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

    public int currentHerb = 0;

    public void UpButton()
    {
        switch (currentHerb)
        {
            case 0:
                return;
            case 1:
                clover.SetActive(true);
                holly.SetActive(false);
                currentHerb--;
                break;
            case 2:
                holly.SetActive(true);
                ivySprig.SetActive(false);
                currentHerb--;
                break;
            case 3:
                ivySprig.SetActive(true);
                willowTwig.SetActive(false);
                currentHerb--;
                break;
            case 4:
                willowTwig.SetActive(true);
                roseThorn.SetActive(false);
                currentHerb--;
                break;
            case 5:
                roseThorn.SetActive(true);
                goosegrass.SetActive(false);
                currentHerb--;
                break;
            case 6:
                goosegrass.SetActive(true);
                windrush.SetActive(false);
                currentHerb--;
                break;
            case 7:
                windrush.SetActive(true);
                firegrass.SetActive(false);
                currentHerb--;
                break;
            case 8:
                firegrass.SetActive(true);
                daisyPetal.SetActive(false);
                currentHerb--;
                break;
            case 9:
                daisyPetal.SetActive(true);
                moly.SetActive(false);
                currentHerb--;
                break;
            case 10:
                moly.SetActive(true);
                knotweed.SetActive(false);
                currentHerb--;
                break;
            case 11:
                knotweed.SetActive(true);
                bitterroot.SetActive(false);
                currentHerb--;
                break;
            case 12:
                bitterroot.SetActive(true);
                baneberry.SetActive(false);
                currentHerb--;
                break;
            case 13:
                baneberry.SetActive(true);
                starthistle.SetActive(false);
                currentHerb--;
                break;
            case 14:
                starthistle.SetActive(true);
                mandrakeRoot.SetActive(false);
                currentHerb--;
                break;
            case 15:
                mandrakeRoot.SetActive(true);
                spleenwort.SetActive(false);
                currentHerb--;
                break;
            case 16:
                spleenwort.SetActive(true);
                tawnymothWeed.SetActive(false);
                currentHerb--;
                break;
            case 17:
                tawnymothWeed.SetActive(true);
                dragonIvy.SetActive(false);
                currentHerb--;
                break;
            case 18:
                dragonIvy.SetActive(true);
                valerianRoot.SetActive(false);
                currentHerb--;
                break;
            case 19:
                valerianRoot.SetActive(true);
                helleboreSyrup.SetActive(false);
                currentHerb--;
                break;
            case 20:
                helleboreSyrup.SetActive(true);
                wormwood.SetActive(false);
                currentHerb--;
                break;
            case 21:
                wormwood.SetActive(true);
                silverweed.SetActive(false);
                currentHerb--;
                break;
            case 22:
                silverweed.SetActive(true);
                wolfsbane.SetActive(false);
                currentHerb--;
                break;
            case 23:
                wolfsbane.SetActive(true);
                moondew.SetActive(false);
                currentHerb--;
                break;
            case 24:
                moondew.SetActive(true);
                asphodel.SetActive(false);
                currentHerb--;
                break;
            case 25:
                asphodel.SetActive(true);
                fluxweed.SetActive(false);
                currentHerb--;
                break;
            case 26:
                fluxweed.SetActive(true);
                nightshade.SetActive(false);
                currentHerb--;
                break;
            case 27:
                nightshade.SetActive(true);
                belladonna.SetActive(false);
                currentHerb--;
                break;
            case 28:
                belladonna.SetActive(true);
                tormentil.SetActive(false);
                currentHerb--;
                break;
            case 29:
                tormentil.SetActive(true);
                bloodroot.SetActive(false);
                currentHerb--;
                break;
            default:
                return;
        }
    }

    public void DownButton()
    {
        switch (currentHerb)
        {
            case 0:
                clover.SetActive(false);
                holly.SetActive(true);
                currentHerb++;
                break;
            case 1:
                holly.SetActive(false);
                ivySprig.SetActive(true);
                currentHerb++;
                break;
            case 2:
                ivySprig.SetActive(false);
                willowTwig.SetActive(true);
                currentHerb++;
                break;
            case 3:
                willowTwig.SetActive(false);
                roseThorn.SetActive(true);
                currentHerb++;
                break;
            case 4:
                roseThorn.SetActive(false);
                goosegrass.SetActive(true);
                currentHerb++;
                break;
            case 5:
                goosegrass.SetActive(false);
                windrush.SetActive(true);
                currentHerb++;
                break;
            case 6:
                windrush.SetActive(false);
                firegrass.SetActive(true);
                currentHerb++;
                break;
            case 7:
                firegrass.SetActive(false);
                daisyPetal.SetActive(true);
                currentHerb++;
                break;
            case 8:
                daisyPetal.SetActive(false);
                moly.SetActive(true);
                currentHerb++;
                break;
            case 9:
                moly.SetActive(false);
                knotweed.SetActive(true);
                currentHerb++;
                break;
            case 10:
                knotweed.SetActive(false);
                bitterroot.SetActive(true);
                currentHerb++;
                break;
            case 11:
                bitterroot.SetActive(false);
                baneberry.SetActive(true);
                currentHerb++;
                break;
            case 12:
                baneberry.SetActive(false);
                starthistle.SetActive(true);
                currentHerb++;
                break;
            case 13:
                starthistle.SetActive(false);
                mandrakeRoot.SetActive(true);
                currentHerb++;
                break;
            case 14:
                mandrakeRoot.SetActive(false);
                spleenwort.SetActive(true);
                currentHerb++;
                break;
            case 15:
                spleenwort.SetActive(false);
                tawnymothWeed.SetActive(true);
                currentHerb++;
                break;
            case 16:
                tawnymothWeed.SetActive(false);
                dragonIvy.SetActive(true);
                currentHerb++;
                break;
            case 17:
                dragonIvy.SetActive(false);
                valerianRoot.SetActive(true);
                currentHerb++;
                break;
            case 18:
                valerianRoot.SetActive(false);
                helleboreSyrup.SetActive(true);
                currentHerb++;
                break;
            case 19:
                helleboreSyrup.SetActive(false);
                wormwood.SetActive(true);
                currentHerb++;
                break;
            case 20:
                wormwood.SetActive(false);
                silverweed.SetActive(true);
                currentHerb++;
                break;
            case 21:
                silverweed.SetActive(false);
                wolfsbane.SetActive(true);
                currentHerb++;
                break;
            case 22:
                wolfsbane.SetActive(false);
                moondew.SetActive(true);
                currentHerb++;
                break;
            case 23:
                moondew.SetActive(false);
                asphodel.SetActive(true);
                currentHerb++;
                break;
            case 24:
                asphodel.SetActive(false);
                fluxweed.SetActive(true);
                currentHerb++;
                break;
            case 25:
                fluxweed.SetActive(false);
                nightshade.SetActive(true);
                currentHerb++;
                break;
            case 26:
                nightshade.SetActive(false);
                belladonna.SetActive(true);
                currentHerb++;
                break;
            case 27:
                belladonna.SetActive(false);
                tormentil.SetActive(true);
                currentHerb++;
                break;
            case 28:
                tormentil.SetActive(false);
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
        bladeUI.SetActive(false);
        transform.gameObject.SetActive(false);
    }
}
