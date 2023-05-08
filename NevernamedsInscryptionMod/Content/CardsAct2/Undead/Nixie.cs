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
    static class Nixie
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Nixie",
                "Nixie",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 5,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { TrainedSwimmer.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/nixie_pixel.png")
                );
        }
    }
}