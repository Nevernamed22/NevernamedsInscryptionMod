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
    static class Voltcaster
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Voltcaster",
                 "Voltcaster",
                 1,
                 1,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { GemType.Blue },
                 abilities: new List<Ability>() { Ability.GainBattery },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/voltcaster_pixel.png")
                 );
        }
    }
}