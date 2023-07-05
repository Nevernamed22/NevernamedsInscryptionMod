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
    static class Belladin
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Belladin",
                 "Belladin",
                 0,
                 3,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { GemType.Orange, GemType.Blue },
                 abilities: new List<Ability>() { Ability.WhackAMole, ReturnStrike.ability, Abstain.ability },
                 variableStat: SpecialStatIcon.Bell,
                 specialAbilities: new List<SpecialTriggeredAbility>() { SpecialTriggeredAbility.BellProximity },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/belladin_pixel.png")
                 );
        }
    }
}