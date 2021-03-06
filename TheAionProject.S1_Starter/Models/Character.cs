﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// base class for the player and all game characters
    /// </summary>
    public class Character
    {
        #region ENUMERABLES

        public enum RaceType
        {
            None,
            Human,
            Thorian,
            Xantorian
        }

        

        #endregion

        #region FIELDS

        private string _name;
        private string _planet;
        private int _spaceTimeLocationID;
        private int _age;
        private RaceType _race;

        //private string _fromEarth;

        #endregion

        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int SpaceTimeLocationID
        {
            get { return _spaceTimeLocationID; }
            set { _spaceTimeLocationID = value; }
        }

        public string Planet
        {
            get { return _planet; }
            set { _planet = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public RaceType Race
        {
            get { return _race; }
            set { _race = value; }
        }
        
        

        //public string FromEarth
        //{
        //    get { return _fromEarth; }
        //    set { _fromEarth = value; }
        //}

        #endregion

        #region CONSTRUCTORS

        public Character()
        {

        }

        public Character(string name, RaceType race, int spaceTimeLocationID)
        {
            _name = name;
            _race = race;
            _spaceTimeLocationID = spaceTimeLocationID;
            _planet = Planet;
            //_fromEarth = FromEarth;
        }

        #endregion

        #region METHODS

        public virtual string Greeting()
        {
            
            return $"Hello, my name is {_name} and I am a {_race}.";
        }

        public virtual string FromPlanet()
        {
            return $"I am from the plant {_planet}.";
        }

        #endregion
    }
}
