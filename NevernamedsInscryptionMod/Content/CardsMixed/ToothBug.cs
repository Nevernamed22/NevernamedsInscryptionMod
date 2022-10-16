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
    static class ToothBug
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
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/toothbug.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed ToothBug",
                "Tooth Bug",
                0,
                2,
                metaCategories,
                CardTemple.Nature,
                description: "The... delightful tooth bug. It steals children's teeth while they rest, and adds them to the scale...",
                bloodCost: 1,
                bonesCost: 0,
                appearanceBehaviour: appearanceBehaviour,
                defaultTex: tex,
                abilities: new List<Ability>() { ToothPuller.ability, ToothPuller.ability },
                decals: new List<Texture>() { Plugin.raresignaturetex },

                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/toothbug_emission.png"),
                tribes: new List<Tribe>() { Tribe.Insect }
                );
        }
    }
}