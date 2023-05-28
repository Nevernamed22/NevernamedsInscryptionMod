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
    static class P4kBot
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed P4kBot",
                 "P4kBot",
                 1,
                 1,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                 CardTemple.Tech,
                 description: "",
                 bloodCost: 0,
                 bonesCost: 0,
                 energyCost: 4, 
                 tribes: new List<Tribe>() { },
                 abilities: new List<Ability>() { Act2TrinketBearer.ability },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/p4kbot_pixel.png")
                 );
        }
    }
}