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
    static class ThornyDevil
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed ThornyTail",
                "Thorny Tail",
                0,
                2,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/thornytail.png"),
                abilities: new List<Ability>() { Ability.Sharp, },
                tribes: new List<Tribe>() { Tribe.Reptile },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );


            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/thornydevil.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed ThornyDevil",
                "Thorny Devil",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "Cantankerous bramble of the sands... it's tail is dangerous even when separated",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.Sharp, Ability.TailOnHit },
                tribes: new List<Tribe>() { Tribe.Reptile },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/thornydevil_emission.png"),
                tailLostTexture: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/thornydevil_tailless.png"),
                defaultTailCard: "BeastNevernamed ThornyTail",
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}
