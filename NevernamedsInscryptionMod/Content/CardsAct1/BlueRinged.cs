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
    static class BlueRinged
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/blueringed.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed BlueRinged",
                "Blue-Ringed",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "The Blue-Ringed Octopus. It's venom is one of the most potent in the world...",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,

                abilities: new List<Ability>() { UnfocusedStrike.ability, Ability.Deathtouch, Ability.Submerge },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/blueringed_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}
