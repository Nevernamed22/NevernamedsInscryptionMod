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
    static class Blowfly
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/blowfly.png");
            // Add the card
           CardSetupUtility.NewCard("Nevernamed Blowfly",
                "Blowfly",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "Disgusting.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Traitor.ability, Ability.BuffEnemy },
                tribes: new List<Tribe>() { Tribe.Insect },

                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/blowfly_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}
