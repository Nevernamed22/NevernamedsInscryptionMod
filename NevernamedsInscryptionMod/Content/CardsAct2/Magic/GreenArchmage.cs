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
    static class GreenArchmage
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed GreenArchmage",
                 "Green Archmage",
                 0,
                 2,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { GemType.Green },
                 abilities: new List<Ability>() { SwitchStrike.ability },
                 specialAbilities: new List<SpecialTriggeredAbility>() { SpecialTriggeredAbility.GreenMage },
                 variableStat: SpecialStatIcon.GreenGems,
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/greenarchmage_pixel.png")
                 );
        }
    }
}