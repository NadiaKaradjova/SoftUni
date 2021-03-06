﻿using BirthdayCelebrations.Interfaces;

namespace BirthdayCelebrations.Models
{
    public class Robot : IIdentifiable
    {
        private string model;

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Id { get; private set; }
    }
}