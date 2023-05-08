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
    static class DynaMite
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed DynaMite",
                "Dyna Mite",
                0,
               1,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "Upsettingly predictable wordplay.",
                bloodCost: 0,
                bonesCost: 3,
                abilities: new List<Ability>() { Ability.DrawCopyOnDeath, Ability.ExplodeOnDeath, Abstain.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/dynamite.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() {  NevernamedsTribes.Arachnid },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/dynamite_emission.png")
                );
        }
    }
}