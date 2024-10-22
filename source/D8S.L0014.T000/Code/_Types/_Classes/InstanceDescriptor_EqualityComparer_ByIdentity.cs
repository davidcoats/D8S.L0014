using System;
using System.Collections.Generic;


namespace D8S.L0014.T000
{
    public class InstanceDescriptor_EqualityComparer_ByIdentity : IEqualityComparer<InstanceDescriptor>
    {
        #region Static

        public static InstanceDescriptor_EqualityComparer_ByIdentity Instance { get; } = new InstanceDescriptor_EqualityComparer_ByIdentity();

        #endregion


        public bool Equals(InstanceDescriptor x, InstanceDescriptor y)
        {
            var output = Instances.EqualityOperator.NullCheckDeterminesEquality_Else(
                x,
                y,
                Instances.InstanceDescriptorOperator.Equals_ByIdentity);

            return output;
        }

        public int GetHashCode(InstanceDescriptor obj)
            => Instances.InstanceDescriptorOperator.Get_HashCode_ByIdentity(obj);
    }
}
