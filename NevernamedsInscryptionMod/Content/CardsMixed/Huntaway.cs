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
    static class Huntaway
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/huntaway.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Huntaway",
                "Huntaway",
                2,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The energetic Huntaway. Why dont you throw it a bone?",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Fetch.ability },
                tribes: new List<Tribe>() { Tribe.Canine },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/huntaway_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                defaultEvolutionName: "Tatum"
                );
        }
    }
}
