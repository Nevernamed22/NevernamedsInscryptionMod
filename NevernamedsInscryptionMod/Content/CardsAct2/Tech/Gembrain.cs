using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Gembrain
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Gembrain",
                "Gembrain",
                4,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, Plugin.P03KayceesWizardRegion, CardMetaCategory.ChoiceNode },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 6,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.GemDependant },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/gembrain.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/gembrain_pixel.png")
                );
        }
    }
}