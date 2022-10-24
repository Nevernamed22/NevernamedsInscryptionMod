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
    static class RedCard
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/antlion.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed RedCard",
                "Red Card",
                0,
                0,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode },
                CardTemple.Nature,
                description: "...surely she made this?...",
                bloodCost: 0,
                bonesCost: 0,
                defaultTex: tex,
                onePerDeck: true,
                decals: new List<Texture>() { Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/redcard.png") },
                specialAbilities: new List<SpecialTriggeredAbility>() { BoardWipe.ability },
                traits: new List<Trait>() { },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                preventSigilVictim: true,
                preventSigilHost: true,
                preventCampfire: true
                );
        }
    }
}
