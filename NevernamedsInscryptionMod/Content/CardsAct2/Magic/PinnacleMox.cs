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
    static class PinnacleMox
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed PinnacleMox",
                 "Pinnacle Mox",
                 0,
                 1,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() {  },
                 abilities: new List<Ability>() { PerfectForm.ability },
                 traits:new List<Trait>() { Trait.Gem, Trait.Terrain},
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/pinnaclemox_pixel.png")
                 );
        }
    }
}