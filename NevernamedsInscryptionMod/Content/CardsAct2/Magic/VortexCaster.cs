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
    static class VortexCaster
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed VortexCaster",
                 "Vortex Caster",
                 0,
                 2,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { GemType.Blue },
                 abilities: new List<Ability>() { Downdraft.ability },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/vortexcaster_pixel.png")
                 );
        }
    }
}