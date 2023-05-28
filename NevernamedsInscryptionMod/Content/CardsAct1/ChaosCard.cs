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
    static class ChaosCard
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed ChaosCard",
                "Chaos Card",
                0,
                0,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "...",
                bloodCost: 0,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/antlion.png"),
                onePerDeck: true,
                decals: new List<Texture>() { Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/chaoscard.png") },
                specialAbilities: new List<SpecialTriggeredAbility>() { ChaosCardBehaviour.ability },
                traits: new List<Trait>() { },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CustomAppearances.PixelChaosCardDecal },
                preventSigilVictim: true,
                preventSigilHost: true,
                preventCampfire: true
                );
        }
    }
}