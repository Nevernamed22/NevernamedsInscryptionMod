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
    static class Starling
    {
        public static void Init()
        {
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/starling.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Starling",
                "Starling",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "The flocking starling. It moves in harmonious synchronicity with it's kin.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.Flying },
                tribes: new List<Tribe>() { Tribe.Bird },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                specialAbilities: new List<SpecialTriggeredAbility>() { BirdsOfAFeather.ability },
                variableStat: BirdsOfAFeather.specialStatIcon,
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/starling_emission.png")
                );
        }
    }
}
