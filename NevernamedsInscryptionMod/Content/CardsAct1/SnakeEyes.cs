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
    static class SnakeEyes
    {
        public static void Init()
        {
            // Load the image into a Texture2D object
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/snakeeyes.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed SnakeEyes",
                "Snake Eyes",
                0,
                3,
                categories: new List<CardMetaCategory>() { CardMetaCategory.TraderOffer, CardMetaCategory.ChoiceNode },
                CardTemple.Nature,
                description: "Double ones. Snake Eyes. Roll again, gambler.",
                bloodCost: 2,
                bonesCost: 0,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { },
                defaultTex: tex,
                abilities: new List<Ability>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/snakeeyes_emission.png"),
                tribes: new List<Tribe>() { Tribe.Reptile },
                specialAbilities: new List<SpecialTriggeredAbility>() { DamageDice.ability },
                variableStat: DamageDice.specialStatIcon
                );
        }
    }
}