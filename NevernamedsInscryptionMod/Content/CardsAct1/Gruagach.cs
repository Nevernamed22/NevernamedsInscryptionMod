using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;
using InscryptionAPI.Card;

namespace NevernamedsInscryptionMod
{
    static class Gruagach
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/gruagach.png");

            // Add the card
       CardInfo card =     CardSetupUtility.NewCard("Nevernamed Gruagach",
                "Gruagach",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "The hairy gruagach, a curious beast indeed. It lives only to serve.",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { GiftBearerCustom.ability },
                defaultTex: tex,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/gruagach_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/gruagach_pixel.png"),
                decals: new List<Texture>() { Plugin.raresignaturetex }
                );
            card.SetExtendedProperty("CustomGiftBearerSpawnsRare", "Yes");
        }
    }
}