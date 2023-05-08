using APIPlugin;
using DiskCardGame;
using NevernamedsSigils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class SanguineSlime
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed SanguineSlime",
                "Sanguine Slime",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 4,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Sanguine.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/sanguineslime_pixel.png")
                );
        }
    }
}