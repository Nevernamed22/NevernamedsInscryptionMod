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
    static class SteamConduit
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed SteamConduit",
                "Steam Conduit",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 2,
                abilities: new List<Ability>() { HotConduit.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/steamconduit_pixel.png")
                );
        }
    }
}