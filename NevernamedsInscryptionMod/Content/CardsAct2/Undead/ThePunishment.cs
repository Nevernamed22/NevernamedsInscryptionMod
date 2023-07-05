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
    static class ThePunishment
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed ThePunishment",
                "The Punishment",
                0,
                5,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bonesCost: 1,
                abilities: new List<Ability>() { BoneSpurs.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/thepunishment_pixel.png")
                );
        }
    }
}