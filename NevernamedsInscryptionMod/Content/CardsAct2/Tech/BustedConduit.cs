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
    static class BustedConduit
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BustedConduit",
                "Busted Conduit",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare, Plugin.P03KayceesBastionRegion, Plugin.P03KayceesUndeadRegion },
                CardTemple.Tech,
                description: "",
                energyCost: 2,
                abilities: new List<Ability>() { MalfunctioningConduit.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/bustedconduit.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/bustedconduit_pixel.png")
                );
        }
    }
}