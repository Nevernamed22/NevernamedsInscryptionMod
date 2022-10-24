using APIPlugin;
using DiskCardGame;
using NevernamedsSigils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class TitanicIsopod
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/titanicisopod.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed TitanicIsopod",
                "Titanic Isopod",
                0,
                12,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "It's sheer vastness far surpasses most other earthly beasts...",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() {  },
                defaultTex: tex,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { NevernamedsTribes.Crustacean },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/titanicisopod_emission.png")
                );
        }
    }
}