namespace CustomAttributes
{
    using System;
    
    [Version(1.5)]
    class TestAttribute
    {
        static void Main()
        {
            Type type = typeof(TestAttribute);
            object[] allAttributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute attribute in allAttributes)
            {
                Console.WriteLine("Version: {0}", attribute.Version);
            }
        }
    }
}
