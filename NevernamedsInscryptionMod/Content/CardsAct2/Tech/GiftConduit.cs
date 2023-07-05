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
    static class GiftConduit
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed GiftConduit",
                "Gift Conduit",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Tech,
                description: "",
                energyCost: 3,
                abilities: new List<Ability>() { LootConduit.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/giftconduit_pixel.png")
                );
        }
    }
}