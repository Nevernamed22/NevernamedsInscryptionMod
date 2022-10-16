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
    static class Chochin
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Chochin",
                "Chochin",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 3,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.PreventAttack, Flighty.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/chochin_pixel.png")
                );
        }
    }
}