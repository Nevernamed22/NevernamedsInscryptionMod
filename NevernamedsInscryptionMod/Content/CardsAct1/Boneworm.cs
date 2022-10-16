using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Boneworm
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/boneworm.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Boneworm",
                "Boneworm",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The morbid boneworm. It excells in bringing remains to the surface of the churning soil...",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.BoneDigger },
                tribes: new List<Tribe>() { Tribe.Insect },

                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/boneworm_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}
