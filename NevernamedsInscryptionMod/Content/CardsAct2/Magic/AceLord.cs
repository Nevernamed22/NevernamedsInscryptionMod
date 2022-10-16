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
            // Add the card
            CardSetupUtility.NewCard("Nevernamed AceLord",
                "Ace Lord",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Wizard,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 0,
                gemsCost: new List<GemType>() { GemType.Green, GemType.Orange },
                tribes: new List<Tribe>() { },
                variableStat: SpecialStatIcon.CardsInHand,
                specialAbilities: new List<SpecialTriggeredAbility>() { SpecialTriggeredAbility.CardsInHand },
                abilities: new List<Ability>() {  },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/acelord_pixel.png")
                );
        }
    }
}