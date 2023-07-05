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
    static class StandardBearer
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed StandardBearer",
                 "Standard Bearer",
                 1,
                 2,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { GemType.Green, GemType.Orange },
                 abilities: new List<Ability>() { Herald.ability },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/standardbearer_pixel.png")
                 );
        }
    }
}