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
    static class Ziburinis
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Ziburinis",
                "Ziburinis",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 2,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ignition.ability, Ability.Brittle },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/ziburinis_pixel.png")
                );
        }
    }
}