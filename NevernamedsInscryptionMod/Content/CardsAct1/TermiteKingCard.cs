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
    static class TermiteKingCard
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/termitekingcard.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed TermiteKing",
                "Termite King",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The dedicated termite king. He and his brood change the landscape with remarkable efficiency.",
                bloodCost: 1,
                bonesCost: 1,
                defaultTex: tex,
                abilities: new List<Ability>() { TermiteKing.ability, Landscaper.ability },
                tribes: new List<Tribe>() { Tribe.Insect },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/termitekingcard_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}

