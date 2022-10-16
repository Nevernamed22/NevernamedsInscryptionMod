using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Mayfly
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/mayfly.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Mayfly",
                "Mayfly",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPlayable, CardMetaCategory.GBCPack },
                CardTemple.Nature,
                description: "The fleeting mayfly. It lives only to die after one turn. A grim parable.",
                bloodCost: 0,
                bonesCost: 1,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.Flying, Ability.Brittle },
                tribes: new List<Tribe>() { Tribe.Insect},
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/mayfly_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/mayfly_pixel.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}
