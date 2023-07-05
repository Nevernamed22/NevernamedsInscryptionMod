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
    static class CrimsonPaladin
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed CrimsonPaladin",
                 "Crimson Paladin",
                 0,
                 2,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { GemType.Orange },
                 tribes: new List<Tribe>() { },
                 abilities: new List<Ability>() { Spellsword.ability },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/crimsonpaladin_pixel.png")
                 );
        }
    }
}