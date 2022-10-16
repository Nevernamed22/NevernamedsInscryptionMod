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
    static class BlackGiantSquirrel
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/blackgiantsquirrel.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed BlackGiantSquirrel",
                "Black Giant Squirrel",
                3,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "The shadowy Black Giant Squirrel. It hits hard and is easily deployed, but perishes with no brothers or sisters by it's side...",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { SquirrelDependent.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/blackgiantsquirrel_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}
