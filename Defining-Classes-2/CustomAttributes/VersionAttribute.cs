namespace CustomAttributes
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = true)]
    class VersionAttribute : System.Attribute
    {
        private double version;

        public VersionAttribute(double version)
        {
            this.version = version;
        }

        public double Version
        {
            get { return this.version; }
        }
    }
}
