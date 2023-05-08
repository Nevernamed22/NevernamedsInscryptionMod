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
    static class Goldfinch
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Goldfinch",
                "Goldfinch",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "It's golden feathers are more than just for show.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/goldfinch.png"),
                abilities: new List<Ability>() { Ability.Flying, Valuable.ability, },
                tribes: new List<Tribe>() { Tribe.Bird },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.GoldEmission},
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/goldfinch_emission.png")
                );
        }
    }
}
