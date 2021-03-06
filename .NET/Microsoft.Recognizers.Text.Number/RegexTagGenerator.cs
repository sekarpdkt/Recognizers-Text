﻿namespace Microsoft.Recognizers.Text.Number
{
    public static class RegexTagGenerator
    {
        private static int priority;
        public static TypeTag GenerateRegexTag(string extractorType, string suffix)
        {
            return new TypeTag($"{extractorType}{suffix}", ++priority);
        }
    }

    public class TypeTag
    {
        public string Name { get; }
        public int Priority { get; }

        public TypeTag(string name, int priority)
        {
            Name = name;
            Priority = priority;
        }
    }
}
