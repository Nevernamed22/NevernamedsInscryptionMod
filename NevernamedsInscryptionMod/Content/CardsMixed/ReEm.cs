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
    static class ReEm
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/reem.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed ReEm",
                "Re'em",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The ever-moving Re'em. It attacks anything opposing it's desired destination.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { RunningStrike.ability },
                tribes: new List<Tribe>() { Tribe.Hooved },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/reem_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}
