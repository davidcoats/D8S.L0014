using System;

using R5T.T0142;


namespace D8S.L0014.T000
{
    /// <summary>
    /// Base class for instance sources.
    /// </summary>
    [DataTypeMarker]
    public abstract class InstanceSource : IEquatable<InstanceSource>
    {
        #region Static

        public static bool operator ==(InstanceSource a, InstanceSource b)
            => a.Equals(b);

        public static bool operator !=(InstanceSource a, InstanceSource b)
            => !a.Equals(b);

        #endregion


        public abstract bool Equals(InstanceSource other);

        public override bool Equals(object obj)
        {
            var output = this.Equals(obj as InstanceSource);
            return output;
        }

        public abstract override int GetHashCode();
    }
}
