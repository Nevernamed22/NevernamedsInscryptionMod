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
    static class Fantail
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/fantail.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed Fantail",
                "Fantail",
                1,
               3,
                new List<CardMetaCategory> { CardMetaCategory.Rare, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "A melodic fantail. The flick of it's tailfeathers sends other cards into the air.",
                bloodCost: 1,
                bonesCost: 0,
                abilities: new List<Ability>() { Ability.Flying, FanTailed.ability },
                defaultTex: tex,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Bird },
                  pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/fantail_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/fantail_emission.png"),
                decals: new List<Texture>() { Plugin.raresignaturetex },
                defaultEvolutionName: "Piwakawaka"
                );
        }
    }
}