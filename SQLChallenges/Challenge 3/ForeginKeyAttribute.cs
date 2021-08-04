using System;

namespace SQLChallenges.Challenge_3
{
    internal class ForeginKeyAttribute : Attribute
    {
        public ForeginKeyAttribute(string v)
        {
            V = v;
        }

        public string V { get; }
    }
}