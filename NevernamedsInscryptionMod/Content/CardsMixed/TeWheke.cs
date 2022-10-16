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
    static class TeWheke
    {
        public static void Init()
        {
            // metaCategories determine the card pools
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>
            {
                CardMetaCategory.Rare,
                //CardMetaCategory.TraderOffer,
            };
            List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>
            {
                CardAppearanceBehaviour.Appearance.RareCardBackground,
            };



            // Load the image into a Texture2D object
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/tewheke.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed TeWheke",
                "Te Wheke",
                1,
                5,
                metaCategories,
                CardTemple.Nature,
                description: "Te Wheke, that murderous octopus... It's flailing tendrils hit many times, but where they land is anyone's guess.",
                bloodCost: 3,
                bonesCost: 0,
                appearanceBehaviour: appearanceBehaviour,
                defaultTex: tex,
                abilities: new List<Ability>() { UnfocusedStrike.ability, Ability.TriStrike, Ability.Submerge },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/tewheke_emission.png"),
                decals: new List<Texture>() { Plugin.raresignaturetex }
                );
        }
    }
}
