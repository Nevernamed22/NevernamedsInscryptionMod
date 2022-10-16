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
    static class IIEyes
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed IIEyes",
                "I.I.",
                2,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 5,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { TwinBond.ability, Flighty.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/iieyes_pixel.png")
                );
        }
    }
}