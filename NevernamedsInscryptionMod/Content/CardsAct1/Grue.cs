using APIPlugin;
using DiskCardGame;
using InscryptionAPI.Card;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;

namespace NevernamedsInscryptionMod
{
    static class Grue
    {
        public static void Init()
        {
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/grue.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed Grue",
                "Grue",
                1,
                5,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The elusive Grue, never once seen by the light of day. It strikes an additional time for each snuffed candle at the table. It is pitch black here...",
                bloodCost: 0,
                bonesCost: 7,
                abilities: new List<Ability>() { },
                defaultTex: tex,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CustomAppearances.GrueAppearance },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/grue_emission.png"),
                titleGraphic: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/grue_title.png"),
                specialAbilities: new List<SpecialTriggeredAbility>() { GrueAttackColourOverride.ability }
                );
        }
    }
}