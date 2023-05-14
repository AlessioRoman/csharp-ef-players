﻿using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(20)]
        public string Surname { get; set; }

        public int Score { get; set; }

        public int NumberOfWins { get; set; }

        public int NumberOfMatches { get; set; }

        //Navigation attributes
        public int? TeamId { get; set; }
        public Team Team { get; set; }

        public Player(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            this.Score = Utility.GenerateScore();
            this.NumberOfMatches = Utility.GenerateMatches();
            this.NumberOfWins = Utility.GenerateWins(NumberOfMatches);
        }

        public void ChangeTeam(Team newTeam)
        {
            Team = newTeam;
        }

        public override string ToString()
        {
            string playerReppresentation = "-------------------------------\n" +
                "Nome: " + Name +
                "Cognome: " + Surname +
                "Punteggio: " + Score +
                "Numero di partite giocate: " + NumberOfMatches +
                "Numero di partite vinte: " + NumberOfWins +
                "Team: " + Team.Name;
            return playerReppresentation;
        }
    }
}