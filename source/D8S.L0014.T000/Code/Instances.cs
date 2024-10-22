using System;


namespace D8S.L0014.T000
{
    public static class Instances
    {
        public static R5T.L0066.IEqualityOperator EqualityOperator => R5T.L0066.EqualityOperator.Instance;
        public static R5T.L0066.IHashCodeOperator HashCodeOperator => R5T.L0066.HashCodeOperator.Instance;
        public static IInstanceDescriptorOperator InstanceDescriptorOperator => T000.InstanceDescriptorOperator.Instance;
        public static R5T.L0066.INullOperator NullOperator => R5T.L0066.NullOperator.Instance;
        public static R5T.L0066.ITypeOperator TypeOperator => R5T.L0066.TypeOperator.Instance;
    }
}