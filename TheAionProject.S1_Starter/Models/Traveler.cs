﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// the character class the player uses in the game
    /// </summary>
    public class Traveler : Character
    {
        #region ENUMERABLES


        #endregion

        #region FIELDS

        private string _homePlanet;


        #endregion


        #region PROPERTIES
        public string HomePlanet
        {
            get { return _homePlanet; }
            set { _homePlanet = value; }
        }

        #endregion


        #region CONSTRUCTORS

        public Traveler()
        {

        }

        public Traveler(string name, RaceType race, int spaceTimeLocationID, string FromEarth) : base(name, race, spaceTimeLocationID,FromEarth)
        {

        }

        #endregion


        #region METHODS

        public bool TravelerFromEarth()
        {
            bool fromEarth = false;

            while (!fromEarth)
            {
                string userInput = Console.ReadLine().ToUpper();
                if (userInput == "Earth")
                {
                    Console.WriteLine("No way! I'm from Earth too!");
                }
                else
                {
                    fromEarth = true;
                }
            }

            return true;

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public override string Greeting()
        {
            return $"Hello, my name is {base.Name}, I am a {Race} and I am from {HomePlanet}.";

            TravelerFromEarth();
        }

        #endregion
    }
}
