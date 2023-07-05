using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class ExplodingAnt
    {
        public static void Init()
        {
            // metaCategories determine the card pools
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>
            {
                CardMetaCategory.ChoiceNode,
                CardMetaCategory.TraderOffer,
                CardMetaCategory.GBCPack,
                CardMetaCategory.GBCPlayable
            };
            List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance> { };

            List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>
            {
                SpecialTriggeredAbility.Ant
            };

            // Load the image into a Texture2D object
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/explodingant.png");

            // Add the card
            CardSetupUtility.NewCard("Exploding_Ant",
                "Exploding Ant",
                0,
                2,
                metaCategories,
                CardTemple.Nature,
                description: "The exploding ant... it will viciously pop in it's final moments.",
                bloodCost: 1,
                appearanceBehaviour: appearanceBehaviour,
                defaultTex: tex,
                specialAbilities: specialAbilities,
                abilities: new List<Ability>() { Ability.ExplodeOnDeath },
                tribes: new List<Tribe>() { Tribe.Insect },
                emissionTex : Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/explodingant_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/explodingant_pixel.png"),
                variableStat : SpecialStatIcon.Ants,
                traits : new List<Trait>() { Trait.Ant }
                );
        }
    }
}
