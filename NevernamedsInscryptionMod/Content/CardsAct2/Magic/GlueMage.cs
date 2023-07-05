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
    static class GlueMage
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed GlueMage",
                "Glue Mage",
               1,
               3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Wizard,
                description: "",
                gemsCost: new List<GemType>() { GemType.Green },
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Gooey.ability, EmeraldDependant.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/gluemage_pixel.png")
                );
        }
    }
}