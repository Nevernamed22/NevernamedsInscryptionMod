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
    static class Talbot
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Talbot",
                "Talbot",
                2,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The noble Talbot hound. It may recuperate itself with the aid of your bones.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/talbot.png"),
                abilities: new List<Ability>() { Bonefed.ability },
                tribes: new List<Tribe>() { Tribe.Canine },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/talbot_emission.png")
                );
        }
    }
}