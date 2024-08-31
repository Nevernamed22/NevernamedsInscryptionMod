using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;
using InscryptionAPI.Card;

namespace NevernamedsInscryptionMod
{
    static class PackRatKing
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed PackRatKing",
                "Pack Rat King",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "You may add as many pack rats as you wish to this accursed tangle.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/packratking.png"),
                abilities: new List<Ability>() { Ability.RandomConsumable },
                 appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.RareCardBackground },
                tribes: new List<Tribe>() { NevernamedsTribes.Rodent },
                specialAbilities: new List<SpecialTriggeredAbility>() { PackRatEater.ability },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/packratking_emission.png")
                );
        }
    }
}