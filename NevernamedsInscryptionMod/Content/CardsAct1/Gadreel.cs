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
    static class Gadreel
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/gadreel.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed Gadreel",
                "Gadre'el",
                4,
                5,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "Gadre'el the serpent... he answers to no master, and despite his great power he refuses to fight without... encouragement.",
                bloodCost: 1,
                bonesCost: 0,
                abilities: new List<Ability>() { Abstain.ability },
                defaultTex: tex,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Reptile },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/gadreel_emission.png")
                );
        }
    }
}