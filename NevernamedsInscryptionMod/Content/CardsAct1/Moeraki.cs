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
    static class Moeraki
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/moeraki.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed Moeraki",
                "Moeraki",
                2,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "Moeraki, the living boulder- pulled from the sands.",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { MeaninglessBond.ability,  Mason.ability,  Ability.MadeOfStone },
                defaultTex: tex,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/moeraki_emission.png"),
                decals: new List<Texture>() { Plugin.raresignaturetex }
                );
        }
    }
}