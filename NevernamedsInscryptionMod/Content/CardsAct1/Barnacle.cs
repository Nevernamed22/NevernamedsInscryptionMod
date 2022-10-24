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
    static class Barnacle
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/barnacle.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Barnacle",
                "Barnacle",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The unimpressive barnacle. Anything that strikes it will be torn to shreds on it's rough shell.",
                bloodCost: 0,
                bonesCost: 3,
                defaultTex: tex,
                abilities: new List<Ability>() { ReturnStrike.ability, Abstain.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Crustacean },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/barnacle_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}
