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
    static class Monarch
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/monarch.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Monarch",
                "Monarch",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "The beautiful monarch... it somehow understands the medicinal properties of certain herbs.",
                bloodCost: 0,
                bonesCost: 4,
                defaultTex: tex,
                abilities: new List<Ability>() { Medicinal.ability, Ability.Flying },
                tribes: new List<Tribe>() { Tribe.Insect },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/monarch_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}
