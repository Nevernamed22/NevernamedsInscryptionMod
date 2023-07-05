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
    static class Hagfish
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Hagfish",
                "Hagfish",
                1,
                4,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The vile hagfish, it excretes a potent slime to choke and entangle it's attackers.",
                bloodCost: 2,
                bonesCost: 4,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hagfish.png"),
                abilities: new List<Ability>() { Gooey.ability, Absorber.ability },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hagfish_emission.png")
                );
        }
    }
}
