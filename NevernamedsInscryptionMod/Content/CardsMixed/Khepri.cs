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
    static class Khepri
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Khepri",
                "Khepri",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "Khepri, the Scarab Goddess. She will not allow any under her care to perish before their time.",
                bloodCost: 0,
                bonesCost: 4,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/khepri.png"),
                abilities: new List<Ability>() { ImmortalCoil.ability },
                tribes: new List<Tribe>() { Tribe.Insect },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/khepri_emission.png"),
                decals: new List<Texture>() { Plugin.raresignaturetex },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground }
                );
        }
    }
}