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
    static class Lockbot
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Lockbot",
                "L0ckb0t",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 4,
                abilities: new List<Ability>() { Lockdown.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/lockbot_pixel.png")
                );
        }
    }
}