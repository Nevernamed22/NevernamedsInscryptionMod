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
    static class Handragora
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/handragora.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Handragora",
                "Handragora",
                0,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "A peculiar chiral herb. This withered plant is almost shaped like a human hand...",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { ClawingHand.ability, },
                tribes: new List<Tribe>() { },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}
