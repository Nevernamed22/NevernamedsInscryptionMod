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
    static class Bolotnik
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Bolotnik",
                "Bolotnik",
                1,
               2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The bloated swampman. It drags others down to hades- returning for more.",
                bloodCost: 1,
                bonesCost: 0,
                abilities: new List<Ability>() { Ability.DrawCopyOnDeath, WaterborneLatch.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bolotnik.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Reptile },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bolotnik_emission.png")
                );
        }
    }
}