using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Dermestid
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/dermestid.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Dermestid",
                "Dermestid",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The ravenous Dermestid, bringer of bones...",
                bloodCost: 0,
                bonesCost: 2,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.QuadrupleBones, },
                tribes: new List<Tribe>() { Tribe.Insect },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/dermestid_emission.png"),

                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}
