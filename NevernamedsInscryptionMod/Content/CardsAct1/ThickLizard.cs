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
    static class ThickLizard
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed SpringyTail",
                "Springy Tail",
                0,
                3,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/springytail.png"),
                abilities: new List<Ability>() { Ability.WhackAMole, },
                tribes: new List<Tribe>() { Tribe.Reptile },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );


            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/thicklizard.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed ThickLizard",
                "Thick Lizard",
                1,
                4,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "A remarkably hefty reptile. It's tail writhes with exceptional vigour.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.TailOnHit, },
                tribes: new List<Tribe>() { Tribe.Reptile },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/thicklizard_emission.png"),
                defaultTailCard: "Nevernamed SpringyTail",
                tailLostTexture: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/thicklizard_tailless.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}
