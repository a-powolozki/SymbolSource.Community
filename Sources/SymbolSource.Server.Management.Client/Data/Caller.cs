﻿namespace SymbolSource.Server.Management.Client
{
    public partial class Caller
    {
        public override string ToString()
        {
            return string.Format("{0}/{1}({2}={3})", Company, Name, KeyType, KeyValue);
        }

        public override bool Equals(object other)
        {
            return ToString().Equals(other.ToString());
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
