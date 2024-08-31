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
    static class RatQueen
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed RatQueen",
                "Rat Queen",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The matriarchal rat queen is never alone... not with her prolific brood.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/ratqueen.png"),
                abilities: new List<Ability>() { Kindred.ability },
                 appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.RareCardBackground },
                tribes: new List<Tribe>() { NevernamedsTribes.Rodent },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/ratqueen_emission.png")
                );
        }
    }
}