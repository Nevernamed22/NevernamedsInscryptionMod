using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Leech
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/leech.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Leech",
                "Leech",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "The disquieting leech. Though it is but a juvenile, it's bloodsucking habits will surely reap great rewards.",
                bloodCost: 0,
                bonesCost: 3,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.Evolve },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/leech_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/leech_pixel.png"),
                defaultEvolutionCard: "Nevernamed BloatedLeech"
                );
        }
    }
}
