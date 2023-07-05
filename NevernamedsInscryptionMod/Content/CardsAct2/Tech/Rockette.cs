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
    static class Rockette
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Rockette",
                "Rockette",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode },
                CardTemple.Tech,
                description: "",
                energyCost: 6,
                abilities: new List<Ability>() { SplashDamage.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/rockette.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/rockette_pixel.png")
                );
        }
    }
}