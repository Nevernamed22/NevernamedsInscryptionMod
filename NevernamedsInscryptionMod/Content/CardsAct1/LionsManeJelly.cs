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
    static class LionsManeJelly
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed LionsManeJelly",
                "Lion's Mane Jelly",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The massive lion's mane jelly... it's stinging tentrils reach far and wide.",
                bonesCost: 8,
               // bonesCost: 2,
                //energyCost: 6,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/lionsmanejelly.png"),
                abilities: new List<Ability>() { Ability.AllStrike, Ability.Deathtouch, Ability.Brittle },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/lionsmanejelly_emission.png")
                );
        }
    }
}