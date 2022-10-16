using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Goose
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/goose.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed_Goose",
                "Goose",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "The irritable goose, it's incessant troublemaking and terrible cacophony enrages it's foes.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.BuffEnemy },
                tribes: new List<Tribe>() { Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/goose_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/goose_pixel.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}
