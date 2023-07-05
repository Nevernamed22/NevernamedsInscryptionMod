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
    static class PracticeSage
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed PracticeSage",
                 "Practice Sage",
                 0,
                 3,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { GemType.Green },
                 traits: new List<Trait>() { Trait.Terrain },
                 abilities: new List<Ability>() { Traitor.ability, SplashZone.ability },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/practicesage_pixel.png")
                 );
        }
    }
}