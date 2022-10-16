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
    static class NightMare
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/nightmare.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed NightMare",
                "Night Mare",
                2,
                4,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The Night Mare... it crushes all hope, and leaves a steady trail of suffering that only fuels it more.",
                bloodCost: 2,
                bonesCost: 3,
                defaultTex: tex,
                abilities: new List<Ability>() { Trampler.ability },
                tribes: new List<Tribe>() { Tribe.Hooved },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/nightmare_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                defaultEvolutionName: "Waking Night Mare",
                flipPortraitWhenStrafing: true
                );
        }
    }
}
