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
    static class NanoConduit
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed NanoConduit",
                "Nano Conduit",
                0,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Tech,
                description: "",
                energyCost: 3,
                abilities: new List<Ability>() { NevernamedsSigils.NanoConduit.ability, Ability.DeathShield },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/nanoconduitcard_pixel.png")
                );
        }
    }
}