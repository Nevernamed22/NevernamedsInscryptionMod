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
    static class TheFlesh
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/theflesh.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed TheFlesh",
                "The Flesh",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "This... mistake of creation... will assimilate any beasts who dare draw near... sleep with one eye open.",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() {  },
                defaultTex: tex,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { },
                specialAbilities: new List<SpecialTriggeredAbility>() { AbsorbOtherCards.ability },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/theflesh_emission.png")
                );
        }
    }
}