﻿using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using Beam;
using Beam.AI;

namespace StrandardDeep_Cheat
{
    public class ResourcesHARVESTRESOURCEESP : MonoBehaviour
    {
        private void Start()
        {

        }
        IEnumerator SleepFor(float Time)
        {
            yield return new WaitForSeconds(Time);
        }

        private void OnGUI()
        {
            if (Menu.LootESP == true)
            {
                if (Menu.ResourcesESP)
                {
                    IEnumerable<InteractiveObject_HARVESTRESOURCE> playerProxies = FindObjectsOfType<InteractiveObject_HARVESTRESOURCE>();
                    foreach (InteractiveObject_HARVESTRESOURCE playerProxy in playerProxies)
                    {
                        Player localplayer = FindObjectsOfType<Player>()[0];
                        Vector3 pos = playerProxy.transform.position;
                        float dist = Vector3.Distance(pos, localplayer.transform.position);
                        if (dist < Menu.LoopDist)
                        {
                            //Extremely useful
                            Vector3 posScreen = Camera.main.WorldToScreenPoint(pos);

                            if (posScreen.z > 0 & posScreen.y < Screen.width - 2)
                            {
                                //Interactive_FISHES proxyName = playerProxy.GetComponent<Interactive_FISHES>();

                                string playerName = "Harvest Source";
                                posScreen.y = Screen.height - (posScreen.y + 1f);
                                Render.DrawString(new Vector2(posScreen.x, posScreen.y), ("   " + playerName + string.Format(" [{0:0}m]", (object)dist)), Color.green);
                            }
                        }
                        SleepFor(0.300f);
                    }
                    SleepFor(0.300f);
                }
                SleepFor(0.300f);

            }
        }


        private void Update()
        {

        }
    }
}
