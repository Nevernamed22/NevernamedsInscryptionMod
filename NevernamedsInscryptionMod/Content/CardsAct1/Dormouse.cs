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
    static class Dormouse
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/dormouse.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Dormouse",
                "Dormouse",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A sweet little dormouse. It scampers around, but invariably strikes where it was commanded to.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Flighty.ability, HomeRun.ability },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/dormouse_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}
