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
    static class DiceGoblin
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed DiceGoblin",
                 "Dice Goblin",
                 0,
                 2,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { GemType.Green },
                 abilities: new List<Ability>() { MoxMax.ability },
                 specialAbilities: new List<SpecialTriggeredAbility>() { OneDFour.ability },
                 variableStat: OneDFour.specialStatIcon,
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/dicegoblin_pixel.png")
                 );
        }
    }
}