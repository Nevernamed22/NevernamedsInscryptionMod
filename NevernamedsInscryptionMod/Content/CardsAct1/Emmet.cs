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
    static class Emmet
    {
        public static void Init()
        {
            // metaCategories determine the card pools
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>
            {
                CardMetaCategory.Rare, CardMetaCategory.GBCPlayable, CardMetaCategory.GBCPack
            };
            List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>
            {
                CardAppearanceBehaviour.Appearance.RareCardBackground,
            };

            // Load the image into a Texture2D object
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/emmet.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed Emmet",
                "Emmet",
                0,
                2,
                metaCategories,
                CardTemple.Nature,
                description: "The Emmet, emissary of antkind.",
                bloodCost: 2,
                bonesCost: 0,
                appearanceBehaviour: appearanceBehaviour,
                defaultTex: tex,
                abilities: new List<Ability>() { },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/emmet_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/emmet_emission.png"),
                tribes: new List<Tribe>() {Tribe.Insect },
                variableStat: AntPlusTwo.specialStatIcon,
                specialAbilities: new List<SpecialTriggeredAbility>() { AntPlusTwo.ability },
                traits: new List<Trait>() { Trait.Ant }
                );
        }
    }
}