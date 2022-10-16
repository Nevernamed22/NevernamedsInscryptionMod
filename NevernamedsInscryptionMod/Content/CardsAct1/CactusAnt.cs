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
    static class CactusAnt
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/cactusant.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed CactusAnt",
                "Cactus Ant",
                0,
                4,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "A friendly ant covered in sharp thorns. She seems like a valuable companion.",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { SharperQuills.ability, Cute.ability },
                defaultTex: tex,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Insect },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/cactusant_emission.png"),
                specialAbilities: new List<SpecialTriggeredAbility> { SpecialTriggeredAbility.Ant },
               variableStat: SpecialStatIcon.Ants,
                traits: new List<Trait>() { Trait.Ant }
                );
        }
    }
}