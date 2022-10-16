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
    static class Huntsman
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/huntsman.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Huntsman",
                "Huntsman",
                2,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "The territorial huntsman. Adept at both avoiding danger and defending it's home.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { TuckAndRoll.ability, HomeRun.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/huntsman_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                pixelTex : Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/huntsman_pixel.png")
                );
        }
    }
}
