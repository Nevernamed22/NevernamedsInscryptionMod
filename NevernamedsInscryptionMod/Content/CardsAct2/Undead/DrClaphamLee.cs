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
    static class DrClaphamLee
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed DrClaphamLee",
                "Dr Clapham-Lee",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 5,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Medicinal.ability, UnfocusedStrike.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/drclaphamlee_pixel.png")
                );
        }
    }
}