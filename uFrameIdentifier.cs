using System;

namespace uFrame.Attributes
{
    public class uFrameEventMapping : Attribute
    {
        public string Title { get; set; }

        public uFrameEventMapping(string title)
        {
            Title = title;
        }
    }
    /// <summary>
    /// Used by the injection container to determine if a property or field should be injected.
    /// </summary>
    public class uFrameIdentifier : Attribute
    {
        public uFrameIdentifier(string identifier)
        {
            Identifier = identifier;
        }

        public string Identifier { get; set; }

        public uFrameIdentifier()
        {
        }
    }
}