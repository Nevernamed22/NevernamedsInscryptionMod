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
    static class Kokyangwuti
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/kokyangwuti.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed Kokyangwuti",
                "Kokyangwuti",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Rare, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "Kokyangwuti, the matriatch of spiders.",
                bloodCost: 1,
                bonesCost: 0,
                abilities: new List<Ability>() { Ability.BuffNeighbours, Ability.MoveBeside },
                defaultTex: tex,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/kokyangwuti_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/kokyangwuti_emission.png")
                );
        }
    }
}