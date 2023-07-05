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
    static class AceLord
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed AceLord",
                "Ace Lord",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Wizard,
                description: "",
                gemsCost: new List<GemType>() { GemType.Green, GemType.Orange },
                variableStat: SpecialStatIcon.CardsInHand,
                specialAbilities: new List<SpecialTriggeredAbility>() { SpecialTriggeredAbility.CardsInHand },
                abilities: new List<Ability>() {  },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/acelord_pixel.png")
                );
        }
    }
}