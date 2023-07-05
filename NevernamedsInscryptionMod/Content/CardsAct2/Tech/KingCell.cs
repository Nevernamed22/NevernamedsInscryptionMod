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
    static class SelflessCell
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed SelflessCell",
                "Selfless Cell",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 3, //5
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { GiftWhenPoweredCustom.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/selflesscell_pixel.png")
                ).SetExtendedProperty("CustomGiftBearerSpawnsRare", "true");
        }
    }
}