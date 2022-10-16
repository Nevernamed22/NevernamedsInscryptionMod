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
    static class Gnat
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/gnat.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Gnat",
                "Gnat",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The diminutive gnat. The only thing it's tiny brain can comprehend is avoiding danger.",
                bloodCost: 0,
                bonesCost: 3,
                defaultTex: tex,
                abilities: new List<Ability>() {  Ability.Flying, TuckAndRoll.ability },
                tribes: new List<Tribe>() { Tribe.Insect },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/gnat_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}
