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
    static class Hallucigenia
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hallucigenia.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Hallucigenia",
                "Hallucigenia",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The puzzling hallucigenia. It's unclear what way up it stands.",
                bloodCost: 0,
                bonesCost: 5,
                defaultTex: tex,
                abilities: new List<Ability>() { TransformerCustom.ability, Ability.Sharp },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hallucigenia_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                transformerForm: "BeastNevernamed HallucigeniaFlipped"
                );

            // Add the card
            CardSetupUtility.NewCard("Nevernamed HallucigeniaFlipped",
                "Hallucigenia",
                2,
                3,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 0,
                bonesCost: 5,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hallucigeniaflipped.png"),
                abilities: new List<Ability>() { TransformerCustom.ability, Ability.Sniper },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hallucigeniaflipped_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                transformerForm: "BeastNevernamed Hallucigenia"
                );
        }
    }
}
