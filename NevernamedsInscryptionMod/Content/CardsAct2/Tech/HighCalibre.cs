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
    static class HighCalibre
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed HighCalibre",
                "High Calibre",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 5,
                abilities: new List<Ability>() { Ability.Sniper, Piercing.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/highcalibre_pixel.png")
                );
        }
    }
}