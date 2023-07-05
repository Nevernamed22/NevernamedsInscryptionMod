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
    static class BloodWitch
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BloodWitch",
                 "Blood Witch",
                 0,
                 2,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { GemType.Green },
                 abilities: new List<Ability>() {  },
                 specialAbilities: new List<SpecialTriggeredAbility>() { SpecialTriggeredAbility.SacrificesThisTurn },
                 variableStat: SpecialStatIcon.SacrificesThisTurn,
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/bloodwitch_pixel.png")
                 );
        }
    }
}