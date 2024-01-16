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
    static class Mugwump
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/mugwump.png");
            // Add the card
           CardSetupUtility.NewCard("Nevernamed Mugwump",
                "Mugwump",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "Ahh. The Mugwump. Though it aims for perfection, the only real accomplishments attributed to the mugwump are from those so frustrated by it's existence that they are forced to action.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.Submerge, Ability.BuffEnemy },
                tribes: new List<Tribe>() { Tribe.Reptile },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/mugwump_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/mugwump_pixel.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                specialAbilities: new List<SpecialTriggeredAbility>() { Ambitious.ability },
                variableStat: Ambitious.specialStatIcon
                );
        }
    }
}
