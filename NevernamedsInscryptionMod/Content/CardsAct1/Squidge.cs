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
    static class Squidge
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/squidge.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Squidge",
                "Squidge",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The infant squidge... what could it become?",
                bloodCost: 0,
                bonesCost: 2,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.Evolve, Ability.Submerge },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/squidge_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                defaultEvolutionCard: "Kraken"
                );
        }
    }
}
