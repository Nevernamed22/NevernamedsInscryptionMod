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
    static class Prodigy
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Prodigy",
                 "Prodigy",
                 0,
                 4,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() {  },
                 abilities: new List<Ability>() { Ability.Evolve, SapphireDependant.ability },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/prodigy1_pixel.png"),
                 defaultEvolutionCard: "WizardNevernamed Prodigy2"
                 );

            CardSetupUtility.NewCard("Nevernamed Prodigy2",
                 "Prodigy",
                 1,
                 5,
                 new List<CardMetaCategory> {  },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { },
                 abilities: new List<Ability>() { Ability.Evolve, EmeraldDependant.ability },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/prodigy2_pixel.png"),
                  defaultEvolutionCard: "WizardNevernamed Prodigy3"
                 );

            CardSetupUtility.NewCard("Nevernamed Prodigy3",
                 "Prodigy",
                 2,
                 6,
                 new List<CardMetaCategory> { },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { },
                 abilities: new List<Ability>() { Ability.Evolve, RubyDependant.ability },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/prodigy3_pixel.png"),
                  defaultEvolutionCard: "WizardNevernamed MageAdept"
                 );

            CardSetupUtility.NewCard("Nevernamed MageAdept",
                 "Mage Adept",
                 8,
                 8,
                 new List<CardMetaCategory> { },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { },
                 abilities: new List<Ability>() {  },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/mageadept_pixel.png")
                 );
        }
    }
}