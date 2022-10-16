using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class BlackDog
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/blackdog.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed BlackDog",
                "Black Dog",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The grim black dog, haunter of graveyards... omen incarnate.",
                bloodCost: 0,
                bonesCost: 6,
                abilities: new List<Ability>() { Ability.CorpseEater, Ability.DrawCopyOnDeath, Ability.Brittle },
                defaultTex: tex,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Canine },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/blackdog_emission.png")
                );
        }
    }
}