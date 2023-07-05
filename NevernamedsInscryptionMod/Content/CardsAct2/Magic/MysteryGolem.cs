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
    static class MysteryGolem
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed MysteryGolem",
                 "Mystery Golem",
                 1,
                 1,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { GemType.Blue },
                 abilities: new List<Ability>() { MysteryMox.ability },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/mysterygolem_pixel.png")
                 );
        }
    }
}