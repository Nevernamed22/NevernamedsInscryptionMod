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
    static class AxeMurderer
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed AxeMurderer",
                "Axe Murderer",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bonesCost: 7,
                abilities: new List<Ability>() { Cleaving.ability, Ability.SplitStrike },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/axemurderer_pixel.png")
                );
        }
    }
}