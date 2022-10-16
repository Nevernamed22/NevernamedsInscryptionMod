using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Cobra
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/cobra.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Cobra",
                "Cobra",
                0,
                4,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The swift cobra. Usually passive, but it delivers a nasty bite when startled.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.Sentry },
                tribes: new List<Tribe>() { Tribe.Reptile },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/cobra_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                defaultEvolutionCard: "Nevernamed KingCobra"

                );
        }
    }
}
