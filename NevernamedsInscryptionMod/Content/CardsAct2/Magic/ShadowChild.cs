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
    static class ShadowChild
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed ShadowChild",
                 "Shadow Child",
                 1,
                 2,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { GemType.Green },
                 abilities: new List<Ability>() { Fearsome.ability },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/shadowchild_pixel.png")
                 );
        }
    }
}