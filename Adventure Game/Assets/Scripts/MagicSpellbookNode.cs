using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicSpellbookNode : MonoBehaviour {

    public TrailRenderer bladeTrail;

    public GameObject[] nodes = new GameObject[11];

    public Image progressBar;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "UI Blade")
        {
            string name = "Node" + (MagicSpellCreation.nodesDone + 1).ToString();
            if (MagicSpellCreation.nodesDone == 0 && gameObject.name == "Node1")
            {
                progressBar.fillAmount += 0.05f;
                MagicSpellCreation.nodesDone++;
            }
            else if(gameObject.name == name)
            {
                progressBar.fillAmount += 0.05f;
                MagicSpellCreation.nodesDone++;
                if (MagicSpellCreation.numNodes == MagicSpellCreation.nodesDone)
                {
                    bladeTrail = collision.GetComponentInChildren<TrailRenderer>();
                    bladeTrail.emitting = false;
                    bladeTrail.time = 0f;
                    nodes[0].SetActive(true);
                    nodes[MagicSpellCreation.nodesDone - 1].SetActive(false);
                }
                else
                {
                    nodes[MagicSpellCreation.nodesDone].SetActive(true);
                    nodes[MagicSpellCreation.nodesDone - 1].SetActive(false);
                }
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "UI Blade")
        {
            if (MagicSpellCreation.nodesDone == 1 && gameObject.name == "Node1")
            {
                bladeTrail = collision.GetComponentInChildren<TrailRenderer>();
                bladeTrail.time = 10f;
                bladeTrail.emitting = true;
                nodes[1].SetActive(true);
                nodes[0].SetActive(false);
            }
        }
    }
}
