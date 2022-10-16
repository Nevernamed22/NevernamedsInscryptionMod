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
    static class TheGoodDoctor
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed TheGoodDoctor",
                "The Good Doctor",
                1,
                4,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 5,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { OrganThief.ability, },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/thegooddoctor_pixel.png")
                );
        }
    }
}