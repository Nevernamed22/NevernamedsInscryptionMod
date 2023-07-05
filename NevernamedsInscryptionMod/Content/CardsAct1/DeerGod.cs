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
    static class DeerGod
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/deerlord.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed DeerLord",
                "Deer Lord",
                2,
                5,
                new List<CardMetaCategory> { CardMetaCategory.Rare, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "The noble deer lord, messiah of all that walks upon cloven hooves.",
                bloodCost: 3,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { DeusHoof.ability, Ability.Strafe },
                tribes: new List<Tribe>() { Tribe.Hooved },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/deerlord_emission.png"),
                  pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/deerlord_pixel.png"),
                decals: new List<Texture>() { Plugin.raresignaturetex },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground }
                );
        }
    }
}