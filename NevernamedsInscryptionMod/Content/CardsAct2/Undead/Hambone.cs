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
    static class Hambone
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Hambone",
                "Hambone",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bonesCost: 6,
                abilities: new List<Ability>() { Ability.Morsel },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/hambone_pixel.png")
                );
        }
    }
}