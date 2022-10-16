using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Scylla
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/scylla.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed Scylla",
                "Scylla",
                4,
                5,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The omniheaded Scylla... each of her heads hunts a different prey.",
                bloodCost: 4,
                bonesCost: 0,
                abilities: new List<Ability>() { Ability.AllStrike },
                defaultTex: tex,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Reptile },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/scylla_emission.png")
                );
        }
    }
}