using System;
using System.Linq;

[Serializable]
public class Choices: IEquatable<Choices>
{
    public string[] Lines;

    public bool Equals(Choices other) =>
        other != null && other.Lines != null && other.Lines.SequenceEqual(Lines);
}
