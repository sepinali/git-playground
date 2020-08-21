using System;

namespace repos.Models
{
    public class CustomModel{
        public string Name{get;set;}
        public string Email{get;set;}

        public DateTime TimeStamp{get;set;}

        public Guid Id {get;set;}

        public string MetaData{get;set;}
    }
}