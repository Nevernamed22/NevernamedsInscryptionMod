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
    static class Bugbear
    {
        public static void Init()
        {
            // metaCategories determine the card pools
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>
            {
                CardMetaCategory.Rare,
            };
            List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>
            {
                CardAppearanceBehaviour.Appearance.RareCardBackground,
            };



            // Load the image into a Texture2D object
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bugbear.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed Bugbear",
                "Bugbear",
                5,
                4,
                metaCategories,
                CardTemple.Nature,
                description: "The horrifying Bugbear. No creatures wish to remain in it's presence.",
                bloodCost: 3,
                bonesCost: 0,
                appearanceBehaviour: appearanceBehaviour,
                defaultTex: tex,
                abilities: new List<Ability>() { Fearsome.ability },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bugbear_emission.png"),
                decals: new List<Texture>() { Plugin.raresignaturetex },
                tribes : new List<Tribe>() { Tribe.Insect }
                );
        }
    }
}