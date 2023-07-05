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
    static class CowardlyLion
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/cowardlylion.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed CowardlyLion",
                "Cowardly Lion",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "The cowardly lion. It attempts to live up to the ferocity of it's cousins, but with little success.",
                bloodCost: 1,
                bonesCost: 3,
                defaultTex: tex,
                abilities: new List<Ability>() { TrophyHunter.ability, TuckAndRoll.ability },
                specialAbilities: new List<SpecialTriggeredAbility>() { WizardOfOz.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/cowardlylion_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/cowardlylion_pixel.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}
