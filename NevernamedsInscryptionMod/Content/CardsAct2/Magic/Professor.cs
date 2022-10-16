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
    static class Professor
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Professor",
                "Professor",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Wizard,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 0,
                gemsCost: new List<GemType>() { GemType.Blue },
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.BuffNeighbours },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/professor_pixel.png")
                );
        }
    }
}