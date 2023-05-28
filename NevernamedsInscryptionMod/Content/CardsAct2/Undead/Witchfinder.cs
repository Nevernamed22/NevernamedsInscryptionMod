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
    static class Witchfinder
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Witchfinder",
                "Witchfinder",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 5,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Antimagic.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/witchfinder_pixel.png")
                );
        }
    }
}