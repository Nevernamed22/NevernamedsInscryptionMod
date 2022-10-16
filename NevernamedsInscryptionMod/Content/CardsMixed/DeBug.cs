using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;

namespace NevernamedsInscryptionMod
{
    static class DeBug
    {
        public static void Init()
        {
            
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/debug.png");
            // Add the card
            CardSetupUtility.NewCard("De Bug",
                "De Bug",
                1,
                1,
                new List<CardMetaCategory>{}, //DONT FUCKING COPY THIS YOU NUMPTY
                CardTemple.Nature,
                description: "What... is that?",
                bloodCost: 0,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Tug.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/debug_emission.png"),
                appearanceBehaviour :  new List<CardAppearanceBehaviour.Appearance> { },
                overrideBeesWithinID: "RoboSkeleton"
                );
        }
    }
}
