using System;

using R5T.T0142;


namespace D8S.L0014.T000
{
    [DataTypeMarker]
    public sealed class InstanceIdentityDescriptor : IEquatable<InstanceIdentityDescriptor>
    {
        public string VarietyName { get; set; }
        public string IdentityString { get; set; }
        public InstanceSource Source { get; set; }


        public bool Equals(InstanceIdentityDescriptor other)
        {
            var output = true
                && this.IdentityString == other.IdentityString
                && this.VarietyName == other.VarietyName
                && this.Source == other.Source;

            return output;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as InstanceIdentityDescriptor);
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Combine(
                this.IdentityString,
                this.Source);

            return output;
        }

        public override string ToString()
        {
            var output = $"{this.IdentityString}\n{this.VarietyName}\n{this.Source}";
            return output;
        }
    }
}
