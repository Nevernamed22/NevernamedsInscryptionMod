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
    static class Bluebottle
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Bluebottle",
                "Bluebottle",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The bluebottle... what secrets lie beyond it's squishy facade?",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { Emancipation.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bluebottle.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() {  },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/bluebottle_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bluebottle_emission.png")
                );
        }
    }
}