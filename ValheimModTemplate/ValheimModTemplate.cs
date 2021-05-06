using System;
using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace ValheimModTemplate
{
    [BepInPlugin(ID, "Valheim Plus Build Expansion", version)]
    public class ValheimModTemplate : BaseUnityPlugin
    {
        public const string ID = "";
        public const string version = "0.0.0.0";     

        public Harmony harmony;
        
        public static BepInEx.Logging.ManualLogSource harmonyLog;

        public void Awake()
        {
            harmony = new Harmony(ID);
            harmony.PatchAll();
            harmonyLog = Logger;

            harmonyLog.LogDebug("ValheimModTemplate loaded.");
        }
    }

    #region Utils

    #endregion

    #region Transpilers

    #endregion

    #region Patches 

    #endregion
}
