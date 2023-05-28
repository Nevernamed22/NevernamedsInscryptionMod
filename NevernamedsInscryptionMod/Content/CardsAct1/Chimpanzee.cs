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
    static class Chimpanzee
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Chimpanzee",
                "Chimpanzee",
                1,
                0,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The true utility of the chimp lies in it's dilligent hands...",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/chimpanzee.png"),
                abilities: new List<Ability>() {  },
                tribes: new List<Tribe>() { },
                specialAbilities: new List<SpecialTriggeredAbility>() { HandOnHeart.ability},
                variableStat: HandOnHeart.specialStatIcon,
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/chimpanzee_emission.png")
                );
        }
    }
}
