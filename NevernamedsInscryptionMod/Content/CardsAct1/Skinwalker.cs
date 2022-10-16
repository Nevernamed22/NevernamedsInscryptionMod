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
    static class Skinwalker
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/skinwalker.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Skinwalker",
                "Skinwalker",
                1,
                5,
                new List<CardMetaCategory> { CardMetaCategory.Rare, },
                CardTemple.Nature,
                description: "The Skinwalker. It moves through many faces, hanging limply off it's bones.",
                bloodCost: 0,
                bonesCost: 6,
                defaultTex: tex,
                abilities: new List<Ability>() { SkinAnimator.ability },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/skinwalker_emission.png"),
                decals: new List<Texture>() { Plugin.raresignaturetex },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground }
                );
        }
    }
}
