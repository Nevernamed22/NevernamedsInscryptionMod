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
    static class Bhoot
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Bhoot",
                "Bhoot",
                3,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 6,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Hypermorphic.ability, Ability.Strafe },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/bhoot_pixel.png")
                );
        }
    }
}