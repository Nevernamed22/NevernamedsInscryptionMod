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
    static class Nidhoggr
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/nidhoggr.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed Nithhoggr",
                "Nithhoggr",
                2,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The wicked Nithhoggr. It gnaws the bones of the damned from it's prison, deep beneath",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { EnlargeCustom.ability },
                defaultTex: tex,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Reptile },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/nidhoggr_emission.png")
                );
        }
    }
}