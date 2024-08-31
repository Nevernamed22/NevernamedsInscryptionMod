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
    static class Nisse
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Nisse",
                 "Nisse",
                 1,
                 0,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { GemType.Green },
                 abilities: new List<Ability>() { Ability.WhackAMole },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/nisse_pixel.png"),
                 variableStat: Greenhorn.specialStatIcon,
                 specialAbilities: new List<SpecialTriggeredAbility>() { Greenhorn.ability }
                 );
        }
    }
}