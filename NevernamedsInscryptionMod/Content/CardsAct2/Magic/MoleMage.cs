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
    static class MoleMage
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed MoleMage",
                "Mole Mage",
                0,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Wizard,
                description: "",
                bloodCost: 0,
                gemsCost: new List<GemType>() { GemType.Blue },
                bonesCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.WhackAMole, Ability.Reach, },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/molemage_pixel.png")
                );
        }
    }
}