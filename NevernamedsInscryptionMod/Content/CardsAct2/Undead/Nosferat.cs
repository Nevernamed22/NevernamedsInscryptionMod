using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NevernamedsSigils;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Nosferat
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Nosferat",
                "Nosferat",
                3,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 8,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.LatchBrittle, Ability.LatchBrittle },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/nosferat_pixel.png")
                );
        }
    }
}