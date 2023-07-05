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
    static class MobiusGolem
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed MobiusGolem",
                 "Mobius Golem",
                 2,
                 3,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { GemType.Blue },
                 abilities: new List<Ability>() { PureHeart.ability },
                 traits: new List<Trait>() { Trait.Terrain },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/mobiusgolem_pixel.png")
                 );
        }
    }
}